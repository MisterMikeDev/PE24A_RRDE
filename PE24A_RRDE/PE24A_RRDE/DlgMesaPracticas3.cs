using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<List<int>> ExcelData = new List<List<int>>();
        private bool isLoading = false;
        private Point? draggingPoint = null;
        private int draggingIndex = -1;
        List<Point> points = new List<Point>();
        Timer debouce = new Timer();

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas3()
        {
            InitializeComponent();

            /* ------------------------------------------------------------------------- */
            // Configuración de la ventana
            /* ------------------------------------------------------------------------- */
            this.MinimumSize = new System.Drawing.Size(600, 400);

            /* ------------------------------------------------------------------------- */
            // Estilizar la tabla
            /* ------------------------------------------------------------------------- */
            StylingTable();

            /* ------------------------------------------------------------------------- */
            // Evento de cambio de tamaño
            /* ------------------------------------------------------------------------- */
            DlgMesaPracticas3_Resize(null, null);

            /* ------------------------------------------------------------------------- */
            // Eventos para el canvas
            /* ------------------------------------------------------------------------- */
            PnlCanvas.MouseDown += new MouseEventHandler(PnlCanvas_MouseDown);
            PnlCanvas.MouseMove += new MouseEventHandler(PnlCanvas_MouseMove);
            PnlCanvas.MouseUp += new MouseEventHandler(PnlCanvas_MouseUp);

            /* ------------------------------------------------------------------------- */
            // Debounce para el evento MouseMove
            /* ------------------------------------------------------------------------- */
            debouce.Interval = 10;
            debouce.Tick += new EventHandler((sender, e) =>
            {
                DrawVectors();
                debouce.Stop();
            });
        }

        /* ------------------------------------------------------------------------- */
        // Evento de cambio de tamaño
        /* ------------------------------------------------------------------------- */
        private void DlgMesaPracticas3_Resize(object sender, EventArgs e) { }

        /* ------------------------------------------------------------------------- */
        // Mostrar el canvas
        /* ------------------------------------------------------------------------- */
        private void BtnShowCanvas_Click(object sender, EventArgs e)
        {
            PnlCanvas.Visible = !PnlCanvas.Visible;
        }

        /* ------------------------------------------------------------------------- */
        // Boton que importa el contenido de un archivo Excel
        /* ------------------------------------------------------------------------- */
        private void BtnImport_Click(object sender, EventArgs e)
        {
            PnlCanvas.Visible = true;

            string Path = "C:\\Dev\\learning-csharp\\PE24A_RRDE\\PE24A_RRDE\\Resources\\Data\\Vectors.xlsx";

            List<List<int>> ExcelData = ReadExcel(Path);

            WriteExcelToTable(ExcelData);

            DrawVectors();

        }

        /* ------------------------------------------------------------------------- */
        // Boton que dibuja o redibuja las coords de los puntos en el canvas
        /* ------------------------------------------------------------------------- */
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            DrawVectors();
        }

        /* ------------------------------------------------------------------------- */
        // Leer el contenido del Excel
        /* ------------------------------------------------------------------------- */
        private List<List<int>> ReadExcel(string ExcelPath)
        {
            CheckIsLoading(true);

            if (ExcelData.Count != 0) ExcelData.Clear();

            Excel.Application xlsxApp = new Excel.Application();
            Excel.Workbook xlsxWorkbook = xlsxApp.Workbooks.Open(ExcelPath);
            Excel._Worksheet xlsxWorksheet = xlsxWorkbook.Sheets[1];
            Excel.Range xlsxRange = xlsxWorksheet.UsedRange;

            int rowCount = xlsxRange.Rows.Count,
                colCount = xlsxRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                List<int> row = new List<int>();

                for (int j = 2; j <= colCount; j++)
                {
                    int cellValue = (xlsxRange.Cells[i, j] as Excel.Range).Value2 != null
                         ? Convert.ToInt32((xlsxRange.Cells[i, j] as Excel.Range).Value2)
                         : 0;

                    row.Add(cellValue);
                }

                ExcelData.Add(row);
            }

            xlsxWorkbook.Close();
            xlsxApp.Quit();

            CheckIsLoading(false);

            MessageBox.Show("Datos importados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return ExcelData;
        }

        /* ------------------------------------------------------------------------- */
        // Escribir el contenido del Excel en la tabla
        /* ------------------------------------------------------------------------- */
        private void WriteExcelToTable(List<List<int>> ExcelData)
        {
            DgvVectors.Rows.Clear();
            DgvVectors.Columns.Clear();

            DgvVectors.Columns.Add("vectors", "Vectors");
            DgvVectors.Columns.Add("x", "X");
            DgvVectors.Columns.Add("y", "Y");

            for (int i = 0; i < ExcelData.Count; i++)
            {
                List<int> vectorPair = ExcelData[i];

                string vectorName = $"v{i + 1}";

                int x = vectorPair[0];
                int y = vectorPair[1];

                DgvVectors.Rows.Add(vectorName, x, y);
            }
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar los vectores en el canvas
        /* ------------------------------------------------------------------------- */
        private void DrawVectors()
        {
            points.Clear();

            if (ExcelData.Count < 1 || ExcelData == null)
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            Graphics g = PnlCanvas.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            
            g.Clear(PnlCanvas.BackColor);

            int W = PnlCanvas.Width,
                H = PnlCanvas.Height,
                scale = 4;

            if (ExcelData.Count == 0) return;

            for (int i = 0; i < ExcelData.Count; i++)
            {
                List<int> vectorPair = ExcelData[i];
                int x = vectorPair[0] * scale,
                    y = vectorPair[1] * scale;

                x = Math.Max(0, Math.Min(x, W));
                y = Math.Max(0, Math.Min(y, H));

                points.Add(new Point(x, y));

                int nextX = i + 1 < ExcelData.Count ? ExcelData[i + 1][0] * scale : ExcelData[0][0] * scale,
                    nextY = i + 1 < ExcelData.Count ? ExcelData[i + 1][1] * scale : ExcelData[0][1] * scale;

                nextX = Math.Max(0, Math.Min(nextX, W));
                nextY = Math.Max(0, Math.Min(nextY, H));

                if (i == ExcelData.Count - 1) g.DrawLine(pen, x, y, ExcelData[0][0] * scale, ExcelData[0][1] * scale);
                else g.DrawLine(pen, x, y, nextX, nextY);

                g.FillEllipse(
                    new SolidBrush(Color.Red),
                    x - 5, y - 5, 10, 10
                );
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseDown para el canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isLoading) return;

            int scale = 4,
                radius = 10;

            for (int i = 0; i < ExcelData.Count; i++)
            {
                int x = ExcelData[i][0] * scale,
                    y = ExcelData[i][1] * scale;

                if (Math.Pow(e.X - x, 2) + Math.Pow(e.Y - y, 2) <= Math.Pow(radius, 2))
                {
                    draggingPoint = new Point(x, y);
                    draggingIndex = i;
                    break;
                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseMove para el canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLoading) return;

            bool overPoint = points.Any(p => Math.Sqrt((p.X - e.X) * (p.X - e.X) + (p.Y - e.Y) * (p.Y - e.Y)) <= 10);
            PnlCanvas.Cursor = overPoint ? Cursors.Hand : Cursors.Default;

            if (draggingPoint.HasValue && e.Button == MouseButtons.Left)
            {
                int scale = 4,
                    W = PnlCanvas.Width,
                    H = PnlCanvas.Height,
                    newX = Math.Max(0, Math.Min(e.X, W)) / scale,
                    newY = Math.Max(0, Math.Min(e.Y, H)) / scale;

                ExcelData[draggingIndex] = new List<int> { newX, newY };
                draggingPoint = new Point(newX * scale, newY * scale);

                DgvVectors.Rows[draggingIndex].Cells["x"].Value = newX;
                DgvVectors.Rows[draggingIndex].Cells["y"].Value = newY;

                debouce.Start();
            }
        }

        /* ------------------------------------------------------------------------- */
        // Evento MouseUp para el canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLoading) return;

            draggingPoint = null;
            draggingIndex = -1;
            DrawVectors();
            debouce.Stop();
        }

        /* ------------------------------------------------------------------------- */
        // Verificar si se está cargando
        /* ------------------------------------------------------------------------- */
        private void CheckIsLoading(bool loading)
        {
            isLoading = loading;
            if (isLoading)
            {
                BtnImport.Enabled = false;
                BtnShowCanvas.Enabled = false;
                BtnImport.Text = "Loading...";
                BtnImport.BackColor = Color.FromArgb(162, 0, 255);
            }
            else
            {
                BtnImport.Enabled = true;
                BtnShowCanvas.Enabled = true;
                BtnImport.Text = "Importar";

                BtnImport.BackColor = Color.FromArgb(0, 200, 0);
            }
        }

        /* ------------------------------------------------------------------------- */
        // Estilizar la tabla
        /* ------------------------------------------------------------------------- */
        private void StylingTable()
        {
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

        private void TrackBarLineHeight_Scroll(object sender, EventArgs e)
        {
            int TrackBarValue = TrackBarLineHeight.Value;

            LblLineSize.Text = $"{TrackBarValue}px";
        }
    }
}
