using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // RRDE. 31/01/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgMesaParcticas1 : Form
    {
        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaParcticas1()
        {
            InitializeComponent();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de pruebas de la mesa 1
        /* ------------------------------------------------------------------------- */
        private void BtnTest_Click(object sender, EventArgs e)
        {
            /*
             * Declaración de las varibales
             */
            int num1,
                num2,
                res;
            bool isNumber1 = int.TryParse(TextBoxNum1.Text, out num1),
                 isNumber2 = int.TryParse(TextBoxNum2.Text, out num2);

            /*
             * Se valida si los datos ingresados
             * son realmente numeros
             * @param {isNumber1} bool
             * @param {isNumber2} bool
             * @return void
             * En caso de no cumplir la condicion
             * no devuelve nada y se hace focus al imput
             */
            if (!isNumber1)
            {
                MessageBox.Show("Debes introducir un NUMERO en el imput 1");
                TextBoxNum1.Focus();
                return;
            }
            else if (!isNumber2)
            {
                MessageBox.Show("Debes introducir un NUMERO en el imput 2");
                TextBoxNum2.Focus();
                return;
            }

            /* 
             * Se hace la suma de los numeros
             * @param {isNumber1} bool
             * @param {isNumber2} bool
             * @return {res} int
             */
            res = num1 + num2;

            /*
             * Se muestra un alert del resultado
             */
            MessageBox.Show($"La suma de los numeros es: {res}");
        }

        /* ------------------------------------------------------------------------- */
        // Muestra la tabla de la practica 1
        /* ------------------------------------------------------------------------- */
        private void BtnMostrarPractica1_Click(object sender, EventArgs e)
        {
            DgvTabla1.Visible = !DgvTabla1.Visible;
        }

        /* ------------------------------------------------------------------------- */
        // Rellena la tabla con elementos de prueba
        /* ------------------------------------------------------------------------- */
        private void BtnFillTabla_Click(object sender, EventArgs e)
        {
            DgvTabla1.Rows.Clear();

            int Index = 4, RowReference = 0;

            for (int x = 0; x < Index; x++)
            {
                for (int  y = 0; y < Index; y++)
                {
                    for (int z = 0; z < Index; z++)
                    {
                        DgvTabla1.Rows.Add();
                        DgvTabla1.Rows[RowReference].Cells[0].Value = $"{x}";
                        DgvTabla1.Rows[RowReference].Cells[1].Value = $"{y}";
                        DgvTabla1.Rows[RowReference].Cells[2].Value = $"{z}";
                        RowReference++;
                    }

                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Botón de Activar tabla Practica 2
        /* ------------------------------------------------------------------------- */
        DataGridView DgvTabla2;

        private void CreateCeills()
        {
            int NumColumna = DgvTabla2.ColumnCount;
            bool isNumber;
            Random random = new Random();

            /* ------------------------------------------------------------------------- */
            // Validaciones
            /* ------------------------------------------------------------------------- */

            if (!(NumColumna > 0))
            {
                isNumber = int.TryParse(TextBoxNum1.Text, out NumColumna);
                if (!isNumber)
                {
                    MessageBox.Show("Debes capturar un número de columns");
                    TextBoxNum1.Focus();
                    return;
                }
            }

            DgvTabla2.Rows.Clear();
            DgvTabla2.Columns.Clear();

            /* ------------------------------------------------------------------------- */
            // Agrega columnas
            /* ------------------------------------------------------------------------- */
            for (int i = 1; i <= NumColumna; i++)
            {
                DgvTabla2.Columns.Add($"C{i}", $"{i}");
            }

            /* ------------------------------------------------------------------------- */
            // Agrega las filas
            /* ------------------------------------------------------------------------- */

            for (int r = 1; r <= NumColumna; r++)
            {
                DgvTabla2.Rows.Add();
               
                for (int c = 0; c < NumColumna; c++)
                {
                    DgvTabla2.Rows[r - 1].Cells[c].Value = $"{random.Next() % 10}";
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Construye el componente
            /* ------------------------------------------------------------------------- */
            PnlCentral.Controls.Clear();
            DgvTabla2 = new DataGridView();
            PnlCentral.Controls.Add(DgvTabla2);
            

            /* ------------------------------------------------------------------------- */
            // Genera la configuración basica del componente
            /* ------------------------------------------------------------------------- */
            DgvTabla2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTabla2.Dock = DockStyle.Fill;
            DgvTabla2.Location = new System.Drawing.Point(0, 0);
            DgvTabla2.Name = "DgvTabla2";
            DgvTabla2.RowHeadersWidth = 30;
            DgvTabla2.RowTemplate.Height = 28;
            DgvTabla2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // !!!!!!!!!!
            DgvTabla2.Size = new System.Drawing.Size(678, 429);
            DgvTabla2.TabIndex = 0;
            DgvTabla2.AllowUserToAddRows = false;
            DgvTabla2.AllowUserToResizeRows = false;
            DgvTabla2.AllowUserToResizeColumns = false;
            DgvTabla2.RowHeadersWidth = 4;

            CreateCeills();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de Calcular tabla Practica 2
        // - Sumatoria todas las celdas de la matriz
        // - Sumatoria de todos los pares.
        /* ------------------------------------------------------------------------- */
        private void BtnP2Llenar_Click(object sender, EventArgs e)
        {
            CreateCeills();

            int RowCount = DgvTabla2.RowCount,
                ColCount = DgvTabla2.ColumnCount,
                SumaTotal = 0,
                SumaPar = 0,
                SumaInpar = 0,
                CurrentCeilValue,
                PrevCeilValue = 0;

            bool isWork;

            for ( int i = 0; i < RowCount; i++)
            {
                for ( int j = 0; j < ColCount; j++)
                {
                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la celda actual
                    /* ------------------------------------------------------------------------- */
                    isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j].Value.ToString(), out CurrentCeilValue);

                    if (!isWork)
                    {
                        MessageBox.Show("Hay valores extraños en la matriz");
                        return;
                    }

                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la siguiente celda
                    /* ------------------------------------------------------------------------- */
                    if (j + 1 < ColCount)
                    {
                        isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j + 1].Value.ToString(), out PrevCeilValue);

                        if (!isWork)
                        {
                            MessageBox.Show("Hay valores extraños en la matriz");
                            return;
                        }
                    }

                    /* ------------------------------------------------------------------------- */
                    // Agregar el resultado de la acumulación con el valor de la celda actual
                    /* ------------------------------------------------------------------------- */
                    SumaTotal += CurrentCeilValue;

                    /* ------------------------------------------------------------------------- */
                    // Hace una comprobación de si el valor de la interción de la columna
                    // del valor anterior, sí el numero se sale de la matriz lo ignora
                    // sí el valor de la celda actual es igual al valor de la celda anterior
                    // entonces se pintan ambos de color rojo
                    /* ------------------------------------------------------------------------- */
                    if (j + 1 < ColCount && CurrentCeilValue == PrevCeilValue)
                    {
                        DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        DgvTabla2.Rows[i].Cells[j + 1].Style.BackColor = Color.Red;
                    }

                    /* ------------------------------------------------------------------------- */
                    // En caso de que la celda ya tenga el BackColor en Rojo pasa a la
                    // siguiente iteración, esto para evitar la superpocisión
                    /* ------------------------------------------------------------------------- */

                    /* ------------------------------------------------------------------------- */
                    // Agregar el resultado de la acumulación par con el valor de la celda
                    // en caso de que el valor sea par
                    /* ------------------------------------------------------------------------- */
                    if (CurrentCeilValue % 2 == 0 && DgvTabla2.Rows[i].Cells[j].Style.BackColor != Color.Red)
                    {
                        SumaPar += CurrentCeilValue;
                        DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }

                    /* ------------------------------------------------------------------------- */
                    // Agregar el resultado de la acumulación impar con el valor de la celda
                    // en caso de que el valor sea impar
                    /* ------------------------------------------------------------------------- */
                    if (CurrentCeilValue % 2 != 0 && DgvTabla2.Rows[i].Cells[j].Style.BackColor != Color.Red)
                    {
                        SumaInpar += CurrentCeilValue;
                        DgvTabla2.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                    }
                }
            }

            /* ------------------------------------------------------------------------- */
            // Se le asignan los valores a los inputs y se les da su color respectivo
            /* ------------------------------------------------------------------------- */
            TextBoxSalida1.Text = $"{SumaTotal}";
            TextBoxSalida2.Text = $"{SumaPar}";
            TextBoxSalida3.Text = $"{SumaInpar}";
            TextBoxSalida2.BackColor = Color.Yellow;
            TextBoxSalida3.BackColor = Color.LightGreen;
        }
    }
}
