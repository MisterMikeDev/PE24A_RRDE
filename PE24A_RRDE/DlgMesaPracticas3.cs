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
        private int margin = 20;
        private bool isDragging = false;
        private int selectedPointIndex = -1;
        private Point lastMousePosition;
        private double minX, maxX, minY, maxY;
        private double scaleX, scaleY, scale;
        private double offsetX, offsetY;
        private int rotation = 0;

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
            Point currentPos = e.Location;



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
            else CheckIsVetorHover(currentPos);
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseMove del panel Canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursorPos = e.Location;

            CheckIsVetorHover(cursorPos);

            if (isDragging && selectedPointIndex != -1)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[selectedPointIndex].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[selectedPointIndex].Cells["Y"].Value);

                x += (cursorPos.X - lastMousePosition.X) / scale;
                y -= (cursorPos.Y - lastMousePosition.Y) / scale;

                DgvVectors.Rows[selectedPointIndex].Cells["X"].Value = x;
                DgvVectors.Rows[selectedPointIndex].Cells["Y"].Value = y;

                lastMousePosition = cursorPos;

                CalcAll();
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseUp del panel Canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            PnlCanvas.Cursor = Cursors.Default;
            isDragging = false;
            selectedPointIndex = -1;
            CalcAll();
        }

        /* ------------------------------------------------------------------------- */
        // Evento al cambiar el Margin del poligono
        /* ------------------------------------------------------------------------- */
        private void TrackBarMargin_Scroll(object sender, EventArgs e)
        {
            int MarginValue = TrackBarMargin.Value;
            LblMarginSize.Text = $"{MarginValue}px";
            margin = MarginValue;
            DrawPolygon();
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
        // Evento al cambiar el valor del TrackBar de rotación
        /* ------------------------------------------------------------------------- */
        private void TrackBarRotation_Scroll(object sender, EventArgs e)
        {
            rotation = TrackBarRotation.Value;

            UpdateRotatedPointsInTable();

            LbRotationDeg.Text = $"{rotation}°";
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

            double perimeter = CalcPerimeter();
            double area = CalcArea();

            TextBoxPerimeter.Text = perimeter.ToString("0.00");
            TextBoxArea.Text = area.ToString("0.00");
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

            List<PointF> originalPoints = new List<PointF>();

            for (int i = 0; i < DgvVectors.RowCount; i++)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);
                originalPoints.Add(new PointF((float)x, (float)y));

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

            double centerX = (minX + maxX) / 2.0;
            double centerY = (minY + maxY) / 2.0;
            PointF center = new PointF((float)centerX, (float)centerY);

            List<PointF> rotatedPoints = new List<PointF>();

            foreach (var point in originalPoints)
            {
                var rotatedPoint = RotatePoint(point, center, rotation);
                rotatedPoints.Add(rotatedPoint);
            }

            for (int i = 0; i < rotatedPoints.Count; i++)
            {
                PointF p1 = rotatedPoints[i];
                PointF p2 = i == rotatedPoints.Count - 1 ? rotatedPoints[0] : rotatedPoints[i + 1];

                int scaledX1 = (int)((p1.X - minX) * scale) + margin + (int)offsetX;
                int scaledY1 = (int)((maxY - p1.Y) * scale) + margin + (int)offsetY;
                int scaledX2 = (int)((p2.X - minX) * scale) + margin + (int)offsetX;
                int scaledY2 = (int)((maxY - p2.Y) * scale) + margin + (int)offsetY;

                using (Pen pen = new Pen(Color.Black, LineHeight))
                {
                    g.DrawLine(pen, scaledX1, scaledY1, scaledX2, scaledY2);
                }

                int ellipseSize = 2 * LineHeight + 5;
                int offset = (ellipseSize - LineHeight) / 2;

                g.FillEllipse(Brushes.Black, scaledX1 - offset, scaledY1 - offset, ellipseSize, ellipseSize);

                if (!isDragging)
                {
                    string labelText = $"V{i + 1}";
                    Font font = new Font("Arial", 18);
                    SizeF size = g.MeasureString(labelText, font);
                    g.DrawString(labelText, font, Brushes.Black, scaledX1 - size.Width / 2, scaledY1 - size.Height - 5);
                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Verificar si el cursor está cerca de un vector
        /* ------------------------------------------------------------------------- */
        private bool IsCursorNearPoint(Point cursorPos, Point point, int radius)
        {
            return (Math.Pow(cursorPos.X - point.X, 2) + Math.Pow(cursorPos.Y - point.Y, 2)) <= Math.Pow(radius, 2);
        }

        private void CheckIsVetorHover(Point cursorPos)
        {
            for (int i = 0; i < DgvVectors.RowCount; i++)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);

                int scaledX = (int)((x - minX) * scale) + margin + (int)offsetX;
                int scaledY = (int)((maxY - y) * scale) + margin + (int)offsetY;

                Rectangle pointRect = new Rectangle(scaledX - 5, scaledY - 5, 10, 10);

                if (pointRect.Contains(cursorPos))
                {
                    PnlCanvas.Cursor = Cursors.Hand;
                    break;
                }
                else PnlCanvas.Cursor = Cursors.Default;
            }
        }

        /* ------------------------------------------------------------------------- */
        // Matriz de rotación
        /* ------------------------------------------------------------------------- */
        private PointF RotatePoint(PointF point, PointF center, double angle)
        {
            double radians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(radians);
            double sinTheta = Math.Sin(radians);

            float x = (float)((point.X - center.X) * cosTheta - (point.Y - center.Y) * sinTheta + center.X);
            float y = (float)((point.X - center.X) * sinTheta + (point.Y - center.Y) * cosTheta + center.Y);

            return new PointF(x, y);
        }

        /* ------------------------------------------------------------------------- */
        // Actualizar puntos rotados en la tabla
        /* ------------------------------------------------------------------------- */
        private void UpdateRotatedPointsInTable()
        {
            double angle = rotation * Math.PI / 180.0;

            double centerX = (minX + maxX) / 2.0;
            double centerY = (minY + maxY) / 2.0;
            PointF center = new PointF((float)centerX, (float)centerY);

            for (int i = 0; i < DgvVectors.RowCount; i++)
            {
                double x = Convert.ToDouble(DgvVectors.Rows[i].Cells["X"].Value);
                double y = Convert.ToDouble(DgvVectors.Rows[i].Cells["Y"].Value);

                PointF rotatedPoint = RotatePoint(new PointF((float)x, (float)y), center, rotation);

                DgvVectors.Rows[i].Cells["X"].Value = rotatedPoint.X;
                DgvVectors.Rows[i].Cells["Y"].Value = rotatedPoint.Y;
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
            DgvVectors.BorderStyle = BorderStyle.None;
            DgvVectors.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DgvVectors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvVectors.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DgvVectors.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DgvVectors.BackgroundColor = Color.White;
            DgvVectors.EnableHeadersVisualStyles = false;
            DgvVectors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvVectors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DgvVectors.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvVectors.RowHeadersWidth = 30;
            DgvVectors.RowHeadersWidth = 4;
            DgvVectors.RowTemplate.Height = 28;
            DgvVectors.TabIndex = 0;
            DgvVectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvVectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVectors.AllowUserToResizeColumns = false;
            DgvVectors.AllowUserToResizeRows = false;
            DgvVectors.AllowUserToAddRows = false;

            TrackBarMargin.Value = margin;
            TextBoxPerimeter.Text = "0";
            TextBoxArea.Text = "0";
            BtnImport.Text = "Importar";
            LblMarginSize.Text = $"{margin}px";
        }
    }
}