using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // RRDE. 08/04/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgMesaPracticas3 : Form
    {
        /* ------------------------------------------------------------------------- */
        // Atributos
        /* ------------------------------------------------------------------------- */
        private Excel.Application xlsxApp = null;
        private Excel.Workbook xlsxWorkbook = null;
        private Excel._Worksheet xlsxWorksheet = null;
        private Excel.Range xlsxRange = null;
        private bool isLoading = false;
        private int LineHeight = 1;
        private int margin = 40;
        private bool isDragging = false;
        private int selectedPointIndex = -1;
        private Point lastMousePosition;
        private double minX, maxX, minY, maxY;
        private double scaleX, scaleY, scale;
        private double offsetX, offsetY;

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas3()
        {
            InitializeComponent();

            StyleAllComponents();

            this.MinimumSize = new System.Drawing.Size(600, 400);

            PnlCanvas.MouseDown += new MouseEventHandler(PnlCanvas_MouseDown);
            PnlCanvas.MouseMove += new MouseEventHandler(PnlCanvas_MouseMove);
            PnlCanvas.MouseUp += new MouseEventHandler(PnlCanvas_MouseUp);
            PnlCanvas.Resize += new EventHandler((sender, e) => DrawPolygon());
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseDown del panel Canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !isLoading)
            {
                for (int i = 0; i < DgvVectors.RowCount; i++)
                {
                    double x = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                    double y = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);

                    int scaledX = (int)((x - minX) * scale) + margin + (int)offsetX;
                    int scaledY = (int)((maxY - y) * scale) + margin + (int)offsetY;

                    Rectangle pointRect = new Rectangle(scaledX - 5, scaledY - 5, 10, 10);

                    if (pointRect.Contains(e.Location))
                    {
                        isDragging = true;
                        selectedPointIndex = i;
                        lastMousePosition = e.Location;
                        break;
                    }
                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseMove del panel Canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedPointIndex != -1)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[selectedPointIndex].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[selectedPointIndex].Cells["Y"].Value);

                x += (e.Location.X - lastMousePosition.X) / scale;
                y -= (e.Location.Y - lastMousePosition.Y) / scale;

                DgvVectors.Rows[selectedPointIndex].Cells["X"].Value = x;
                DgvVectors.Rows[selectedPointIndex].Cells["Y"].Value = y;

                lastMousePosition = e.Location;
                CalcAll();
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseUp del panel Canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedPointIndex = -1;
            CalcAll();
        }

        /* ------------------------------------------------------------------------- */
        // Evento al cambiar el LineHeight
        /* ------------------------------------------------------------------------- */
        private void TrackBarLineHeight_Scroll(object sender, EventArgs e)
        {
            int TrackBarValue = TrackBarLineHeight.Value;
            LblLineSize.Text = $"{TrackBarValue}px";
            LineHeight = TrackBarValue;
            DrawPolygon();
        }

        /* ------------------------------------------------------------------------- */
        // Botón para importar datos de Excel
        /* ------------------------------------------------------------------------- */
        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Seleccionar archivo de Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportExcel(openFileDialog.FileName);

                CalcAll();
            }
        }

        /* ------------------------------------------------------------------------- */
        // Botón para mostrar/ocultar el panel Canvas
        /* ------------------------------------------------------------------------- */
        private void BtnShowCanvas_Click(object sender, EventArgs e)
        {
            PnlCanvas.Visible = !PnlCanvas.Visible;
        }

        /* ------------------------------------------------------------------------- */
        // Botón para dibujar el polígono
        /* ------------------------------------------------------------------------- */
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            DrawPolygon();
        }

        /* ------------------------------------------------------------------------- */
        // Calcular perímetro
        /* ------------------------------------------------------------------------- */
        private double CalcPerimeter()
        {
            double perimeter = 0;
            double x1, x2, y1, y2;

            if (DgvVectors.RowCount < 2)
            {
                MessageBox.Show("Se necesitan al menos dos puntos para calcular el perímetro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            x1 = Convert.ToDouble(DgvVectors.Rows[0].Cells["X"].Value);
            y1 = Convert.ToDouble(DgvVectors.Rows[0].Cells["Y"].Value);

            for (int i = 1; i < DgvVectors.RowCount; i++)
            {
                x2 = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                y2 = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);

                perimeter += Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                x1 = x2;
                y1 = y2;
            }

            x2 = Convert.ToDouble(DgvVectors.Rows[0].Cells["X"].Value);
            y2 = Convert.ToDouble(DgvVectors.Rows[0].Cells["Y"].Value);
            perimeter += Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return perimeter;
        }

        /* ------------------------------------------------------------------------- */
        // Calcular área
        /* ------------------------------------------------------------------------- */
        private double CalcArea()
        {
            double area = 0;

            if (DgvVectors.RowCount < 3)
            {
                MessageBox.Show("Se necesitan al menos tres puntos para calcular el área utilizando el método de Shoelace", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            for (int i = 0; i < DgvVectors.RowCount - 1; i++)
            {
                double x1 = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y1 = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);
                double x2 = Convert.ToDouble(DgvVectors.Rows[i + 1].Cells["X"].Value);
                double y2 = Convert.ToDouble(DgvVectors.Rows[i + 1].Cells["Y"].Value);

                area += x1 * y2 - x2 * y1;
            }

            double xLast = Convert.ToDouble(DgvVectors.Rows[DgvVectors.RowCount - 1].Cells["X"].Value);
            double yLast = Convert.ToDouble(DgvVectors.Rows[DgvVectors.RowCount - 1].Cells["Y"].Value);
            double xFirst = Convert.ToDouble(DgvVectors.Rows[0].Cells["X"].Value);
            double yFirst = Convert.ToDouble(DgvVectors.Rows[0].Cells["Y"].Value);

            area += xLast * yFirst - xFirst * yLast;

            area = Math.Abs(area / 2);

            return area;
        }

        /* ------------------------------------------------------------------------- */
        // Calcular perímetro y área
        /* ------------------------------------------------------------------------- */
        private void CalcAll()
        {
            DrawPolygon();

            int perimeter = (int)CalcPerimeter();
            int area = (int)CalcArea();

            TextBoxPerimeter.Text = $"{perimeter}";
            TextBoxArea.Text = $"{area}";
        }

        /* ------------------------------------------------------------------------- */
        // Importar datos de Excel
        /* ------------------------------------------------------------------------- */
        private void ImportExcel(string path)
        {
            SetLoading(true);

            PnlCanvas.Visible = true;

            TextBoxPerimeter.Text = "0";
            TextBoxArea.Text = "0";

            try
            {
                xlsxApp = new Excel.Application();
                xlsxWorkbook = xlsxApp.Workbooks.Open(path);
                xlsxWorksheet = xlsxWorkbook.Sheets[1];
                xlsxRange = xlsxWorksheet.UsedRange;

                int rowCount = xlsxRange.Rows.Count;
                int colCount = xlsxRange.Columns.Count;

                if (colCount < 2)
                {
                    MessageBox.Show("El archivo Excel debe contener al menos 2 columnas (X y Y).");
                    return;
                }

                DgvVectors.Columns.Clear();
                DgvVectors.Rows.Clear();

                DgvVectors.Columns.Add("Vectors", "Vectors");
                DgvVectors.Columns.Add("X", "X");
                DgvVectors.Columns.Add("Y", "Y");

                for (int i = 2; i <= rowCount; i++)
                {
                    if (xlsxRange.Cells[i, 1].Value2 == null || xlsxRange.Cells[i, 2].Value2 == null || xlsxRange.Cells[i, 3].Value2 == null) continue;

                    DgvVectors.Rows.Add(
                        "V" + (i - 1),
                        xlsxRange.Cells[i, 2].Value2.ToString(),
                        xlsxRange.Cells[i, 3].Value2.ToString()
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                SetLoading(false);
                xlsxWorkbook?.Close();
                xlsxApp?.Quit();
            }
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar polígono en el panel Canvas
        /* ------------------------------------------------------------------------- */
        private void DrawPolygon()
        {
            if (DgvVectors.RowCount < 1)
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Graphics g = PnlCanvas.CreateGraphics();
            g.Clear(PnlCanvas.BackColor);

            int canvasWidth = PnlCanvas.Width;
            int canvasHeight = PnlCanvas.Height;

            minX = double.MaxValue;
            maxX = double.MinValue;
            minY = double.MaxValue;
            maxY = double.MinValue;

            for (int i = 0; i < DgvVectors.RowCount; i++)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);

                if (x < minX) minX = x;
                if (x > maxX) maxX = x;
                if (y < minY) minY = y;
                if (y > maxY) maxY = y;
            }

            double rangeX = maxX - minX;
            double rangeY = maxY - minY;

            scaleX = (canvasWidth - 2 * margin) / rangeX;
            scaleY = (canvasHeight - 2 * margin) / rangeY;

            scale = Math.Min(scaleX, scaleY);

            offsetX = (canvasWidth - 2 * margin - scale * rangeX) / 2;
            offsetY = (canvasHeight - 2 * margin - scale * rangeY) / 2;

            for (int i = 0; i < DgvVectors.RowCount; i++)
            {
                double x1 = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y1 = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);
                double x2, y2;

                if (i == DgvVectors.RowCount - 1)
                {
                    x2 = Convert.ToDouble(DgvVectors.Rows[0].Cells["X"].Value);
                    y2 = Convert.ToDouble(DgvVectors.Rows[0].Cells["Y"].Value);
                }
                else
                {
                    x2 = Convert.ToDouble(DgvVectors.Rows[i + 1].Cells["X"].Value);
                    y2 = Convert.ToDouble(DgvVectors.Rows[i + 1].Cells["Y"].Value);
                }

                int scaledX1 = (int)((x1 - minX) * scale) + margin + (int)offsetX;
                int scaledY1 = (int)((maxY - y1) * scale) + margin + (int)offsetY;
                int scaledX2 = (int)((x2 - minX) * scale) + margin + (int)offsetX;
                int scaledY2 = (int)((maxY - y2) * scale) + margin + (int)offsetY;

                using (Pen pen = new Pen(Color.Black, LineHeight))
                {
                    g.DrawLine(pen, scaledX1, scaledY1, scaledX2, scaledY2);
                }

                int ellipseSize = 2 * LineHeight + 5;
                int offset = (ellipseSize - LineHeight) / 2;

                int scaledX = (int)((x1 - minX) * scale) + margin + (int)offsetX;
                int scaledY = (int)((maxY - y1) * scale) + margin + (int)offsetY;
                g.FillEllipse(Brushes.Red, scaledX - offset, scaledY - offset, ellipseSize, ellipseSize);

                if (!isDragging)
                {
                    string labelText = $"V{i + 1}";
                    Font font = new Font("Arial", 18);
                    SizeF size = g.MeasureString(labelText, font);
                    g.DrawString(labelText, font, Brushes.Black, scaledX - size.Width / 2, scaledY - size.Height - 5);
                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Establecer el estado de carga
        /* ------------------------------------------------------------------------- */
        private void SetLoading(bool loading)
        {
            isLoading = loading;
            BtnImport.Text = loading ? "Cargando..." : "Importar";
            BtnImport.Enabled = !loading;
            BtnImport.BackColor = loading ? Color.FromArgb(0, 255, 0) : Color.FromArgb(162, 0, 255);
        }

        /* ------------------------------------------------------------------------- */
        // Estilizar todos los componentes
        /* ------------------------------------------------------------------------- */
        private void StyleAllComponents()
        {
            TextBoxInitialX.Text = "0";
            TextBoxInitialY.Text = "0";
            TextBoxPerimeter.Text = "0";
            TextBoxArea.Text = "0";

            BtnImport.Text = "Importar";

            DgvVectors.AllowUserToResizeColumns = false;
            DgvVectors.AllowUserToResizeRows = false;
            DgvVectors.AllowUserToAddRows = false;

            DgvVectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvVectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            DgvVectors.RowHeadersWidth = 30;
            DgvVectors.RowHeadersWidth = 4;
            DgvVectors.RowTemplate.Height = 28;
            DgvVectors.TabIndex = 0;
        }
    }
}
