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
        private bool isLoading = false;

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas3()
        {
            InitializeComponent();

            StylingTable();

            DlgMesaPracticas3_Resize(null, null);
        }

        /* ------------------------------------------------------------------------- */
        // Evento de cambio de tamaño
        /* ------------------------------------------------------------------------- */
        private void DlgMesaPracticas3_Resize(object sender, EventArgs e)
        {
        }

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

            string Path = "C:\\Dev\\learning-csharp\\PE24A_RRDE\\PE24A_RRDE\\Resources\\Data\\Vectors.xlsx";
            int[][] ExcelData = ReadExcel(Path);

            WriteExcelToTable(ExcelData);
            DrawVectors();

        }

        /* ------------------------------------------------------------------------- */
        // Leer el contenido del Excel
        /* ------------------------------------------------------------------------- */
        private int[][] ReadExcel(string ExcelPath)
        {
            isLoading = true;
            CheckIsLoading();

            Excel.Application xlsxApp = new Excel.Application();
            Excel.Workbook xlsxWorkbook = xlsxApp.Workbooks.Open(ExcelPath);
            Excel._Worksheet xlsxWorksheet = xlsxWorkbook.Sheets[1];
            Excel.Range xlsxRange = xlsxWorksheet.UsedRange;

            int rowCount = xlsxRange.Rows.Count,
                colCount = xlsxRange.Columns.Count;
            int[] ExcelCellDataRaw = new int[colCount * rowCount - (colCount + rowCount - 2) - 1];
            int[][] ExcelCellData = new int[ExcelCellDataRaw.Length / 2][];

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 2; j <= colCount; j++)
                {
                    int cellValue = (xlsxRange.Cells[i, j] as Excel.Range).Value2 != null ?
                        (int)(xlsxRange.Cells[i, j] as Excel.Range).Value2 : 0;

                    ExcelCellDataRaw[(i - 2) * (colCount - 1) + (j - 2)] = cellValue;
                }
            }

            for (int i = 0; i < ExcelCellDataRaw.Length; i += 2)
            {
                ExcelCellData[i / 2] = new int[] { ExcelCellDataRaw[i], ExcelCellDataRaw[i + 1] };
            }

            xlsxWorkbook.Close();
            xlsxApp.Quit();

            isLoading = false;
            CheckIsLoading();

            return ExcelCellData;
        }

        /* ------------------------------------------------------------------------- */
        // Escribir el contenido del Excel en la tabla
        /* ------------------------------------------------------------------------- */
        private void WriteExcelToTable(int[][] ExcelData)
        {
            DgvVectors.Rows.Clear();
            DgvVectors.Columns.Clear();

            DgvVectors.Columns.Add("vectors", "Vectors");
            DgvVectors.Columns.Add("x", "X");
            DgvVectors.Columns.Add("y", "Y");

            for (int i = 0; i < ExcelData.Length; i++)
            {
                DgvVectors.Rows.Add($"v{i + 1}", ExcelData[i][0], ExcelData[i][1]);
            }
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar los vectores en el canvas
        /* ------------------------------------------------------------------------- */
        private void DrawVectors()
        {
            Console.WriteLine($"${PnlCanvas.Width} {PnlCanvas.Height}");
            Random random = new Random();
            Graphics g = PnlCanvas.CreateGraphics();
            

            int x0 = PnlCanvas.Width / 2,
                y0 = PnlCanvas.Height / 2;

            int x = x0,
                y = y0;

            for (int i = 0; i < DgvVectors.Rows.Count; i++)
            {
                Pen pen = new Pen(
                   Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),
                   4
                );

                int x1 = x + (int)DgvVectors.Rows[i].Cells[1].Value,
                    y1 = y - (int)DgvVectors.Rows[i].Cells[2].Value;

                g.DrawLine(pen, x, y, x1, y1);

                x = x1;
                y = y1;
            }
            x = x0;
            y = y0;
        }


        /* ------------------------------------------------------------------------- */
        // Verificar si se está cargando
        /* ------------------------------------------------------------------------- */
        private void CheckIsLoading()
        {
            if (isLoading)
            {
                BtnImport.Enabled = false;
                BtnShowCanvas.Enabled = false;
                LblLoadingText.Visible = true;
                LblLoadingText.Text = "Loading...";
            }
            else
            {
                BtnImport.Enabled = true;
                BtnShowCanvas.Enabled = true;
                LblLoadingText.Visible = false;
                LblLoadingText.Text = "";
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
    }
}
