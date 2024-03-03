using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // RRDE. 31/01/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgMesaPracticas1 : Form
    {
        /* ------------------------------------------------------------------------- */
        // Variables globales
        /* ------------------------------------------------------------------------- */
        DataGridView DgvTabla2;
        bool isFirstTimeToCalculate = true;

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas1()
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

            /* ------------------------------------------------------------------------- */
            // Validaciones
            /* ------------------------------------------------------------------------- */
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

            /* ------------------------------------------------------------------------- */
            // Operación
            /* ------------------------------------------------------------------------- */
            res = num1 + num2;

            /* ------------------------------------------------------------------------- */
            // Muestra el resultado
            /* ------------------------------------------------------------------------- */
            MessageBox.Show($"La suma de los numeros es: {res}");
        }

        /* ------------------------------------------------------------------------- */
        // Muestra la tabla de la practica 1
        /* ------------------------------------------------------------------------- */
        private void BtnMostrarPractica1_Click(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Hace un toggle a la visibilidad de la tabla
            /* ------------------------------------------------------------------------- */
            DgvTabla1.Visible = !DgvTabla1.Visible;
        }

        /* ------------------------------------------------------------------------- */
        // Rellena la tabla con elementos de prueba
        /* ------------------------------------------------------------------------- */
        private void BtnFillTabla_Click(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Limpia la tabla
            /* ------------------------------------------------------------------------- */
            DgvTabla1.Rows.Clear();

            int Index = 4, RowReference = 0;

            for (int x = 0; x < Index; x++)
            {
                for (int  y = 0; y < Index; y++)
                {
                    for (int z = 0; z < Index; z++)
                    {
                        /* ------------------------------------------------------------------------- */
                        // Agrega los valores a la tabla
                        /* ------------------------------------------------------------------------- */
                        DgvTabla1.Rows.Add();

                        /* ------------------------------------------------------------------------- */
                        // Asigna los valores a las celdas
                        /* ------------------------------------------------------------------------- */
                        DgvTabla1.Rows[RowReference].Cells[0].Value = $"{x}";
                        DgvTabla1.Rows[RowReference].Cells[1].Value = $"{y}";
                        DgvTabla1.Rows[RowReference].Cells[2].Value = $"{z}";

                        /* ------------------------------------------------------------------------- */
                        // Incrementa el valor de la referencia de la fila
                        /* ------------------------------------------------------------------------- */
                        RowReference++;
                    }

                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Función que se ejecuta al cargar el formulario
        /* ------------------------------------------------------------------------- */
        private void CreateCeills()
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int NumColumna = DgvTabla2.ColumnCount;
            bool isNumber ;
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

            /* ------------------------------------------------------------------------- */
            // Limpia la tabla
            /* ------------------------------------------------------------------------- */
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
                    /* ------------------------------------------------------------------------- */
                    // Agrega valores aleatorios a las celdas
                    /* ------------------------------------------------------------------------- */
                    DgvTabla2.Rows[r - 1].Cells[c].Value = $"{random.Next() % 10}";
                }
            }
        }

        /* ------------------------------------------------------------------------- */
        // Función que comprueba si todas las celdas de la tabla son rojas
        /* ------------------------------------------------------------------------- */
        private void CheckIfAllTableIsRed ()
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int RowCount = DgvTabla2.RowCount,
                ColCount = DgvTabla2.ColumnCount,
                RedCount = 0;

            /* ------------------------------------------------------------------------- */
            // Itera sobre todas las celdas de la tabla
            /* ------------------------------------------------------------------------- */
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    if (DgvTabla2.Rows[i].Cells[j].Style.BackColor == Color.Red)
                    {
                        RedCount++;
                    }
                }
            }

            /* ------------------------------------------------------------------------- */
            // En caso de que todas las celdas sean rojas muestra un mensaje
            /* ------------------------------------------------------------------------- */
            if (RedCount == RowCount * ColCount)
            {
                MessageBox.Show("Todas las celdas son rojas");
            }   
        }
        private void BtnP2Activar_Click(object sender, EventArgs e)
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
            DgvTabla2.AllowUserToAddRows = false;
            DgvTabla2.AllowUserToResizeColumns = false;
            DgvTabla2.AllowUserToResizeRows = false;
            DgvTabla2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; // !!!!!!!!!!
            DgvTabla2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTabla2.Dock = DockStyle.Fill;
            DgvTabla2.Location = new Point(0, 0);
            DgvTabla2.Name = "DgvTabla2";
            DgvTabla2.RowHeadersWidth = 30;
            DgvTabla2.RowHeadersWidth = 4;
            DgvTabla2.RowTemplate.Height = 28;
            DgvTabla2.Size = new Size(678, 429);
            DgvTabla2.TabIndex = 0;

            /* ------------------------------------------------------------------------- */
            // Agrega las columnas
            /* ------------------------------------------------------------------------- */
            CreateCeills();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de Calcular tabla Practica 2
        // - Sumatoria todas las celdas de la matriz
        // - Sumatoria de todos los pares.
        /* ------------------------------------------------------------------------- */
        private void BtnP2Llenar_Click(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int RowCount = DgvTabla2.RowCount,
                ColCount = DgvTabla2.ColumnCount,
                SumaTotal = 0,
                SumaPar = 0,
                SumaInpar = 0,
                SumaConjuntosRepetidos = 0,
                PrevCeilValue = 0,
                CurrentCeilValue,
                NextCeilValue = 0;
            bool isWork;

            /* ------------------------------------------------------------------------- */
            // En caso de que sea la primera vez que se calcula la matriz no
            // se pinta las celdas, en caso contrario se repintan
            /* ------------------------------------------------------------------------- */
            if (isFirstTimeToCalculate)
            {
                isFirstTimeToCalculate = false;
            } else
            {
                CreateCeills();
            }

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
                        MessageBox.Show("No se puede obtener el valor de la celda actual.");
                        return;
                    }

                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la siguiente celda
                    /* ------------------------------------------------------------------------- */
                    if (j + 1 < ColCount)
                    {
                        isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j + 1].Value.ToString(), out NextCeilValue);

                        if (!isWork)
                        {
                            MessageBox.Show("No se puede obtener el valor de la siguente celda.");
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
                    if (j + 1 < ColCount && CurrentCeilValue == NextCeilValue)
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

            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la celda actual
                    /* ------------------------------------------------------------------------- */
                    isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j].Value.ToString(), out CurrentCeilValue);

                    if (!isWork)
                    {
                        MessageBox.Show("No se puede obtener el valor de la celda actual.");
                        return;
                    }

                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la celda anterior
                    /* ------------------------------------------------------------------------- */
                    if (j > 0)
                    {
                        isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j - 1].Value.ToString(), out PrevCeilValue);

                        if (!isWork)
                        {
                            MessageBox.Show("No se puede obtener el valor de la celda anterior.");
                            return;
                        }
                    }

                    /* ------------------------------------------------------------------------- */
                    // Obtener el valor de la siguiente celda
                    /* ------------------------------------------------------------------------- */
                    if (j + 1 < ColCount)
                    {
                        isWork = int.TryParse(DgvTabla2.Rows[i].Cells[j + 1].Value.ToString(), out NextCeilValue);

                        if (!isWork)
                        {
                            MessageBox.Show("No se puede obtener el valor de la siguente celda.");
                            return;
                        }
                    } else
                    {
                        NextCeilValue = -1;
                    }

                    /* ------------------------------------------------------------------------- */
                    // Hace una comprobación de si el valor de la interción de la columna
                    // del valor anterior, sí el numero se sale de la matriz lo ignora
                    // sí el valor de la celda actual es igual al valor de la celda anterior
                    // entonces se pintan ambos de color rojo
                    /* ------------------------------------------------------------------------- */
                    if (
                        j > 0 &&
                        j < ColCount &&
                        (DgvTabla2.Rows[i].Cells[j].Style.BackColor == Color.Red) &&
                        PrevCeilValue == CurrentCeilValue &&
                        CurrentCeilValue != NextCeilValue
                       )
                    {
                        SumaConjuntosRepetidos++;
                    }
                }
            }

            /* ------------------------------------------------------------------------- */
            // Se le asignan los valores a los inputs y se les da su color respectivo
            /* ------------------------------------------------------------------------- */
            TextBoxSalida1.Text = $"{SumaTotal}";
            TextBoxSalida2.Text = $"{SumaPar}";
            TextBoxSalida3.Text = $"{SumaInpar}";
            TextBoxSalida6.Text = $"{SumaConjuntosRepetidos}";
            TextBoxSalida2.BackColor = Color.Yellow;
            TextBoxSalida3.BackColor = Color.LightGreen;
            TextBoxSalida6.BackColor = Color.Red;

            /* ------------------------------------------------------------------------- */
            // Comprueba si todas las celdas de la tabla son rojas
            /* ------------------------------------------------------------------------- */
            CheckIfAllTableIsRed();
        }

        private void BtnP2Diagonal_Click(object sender, EventArgs e)
        {
            int RowCount = DgvTabla2.RowCount,
                ColCount = DgvTabla2.ColumnCount,
                SumaDiagonal1 = 0,
                SumaDiagonal2 = 0;

            for (int i = 0; i < RowCount; i++)
            {
                /* ------------------------------------------------------------------------- */
                // Se le asigna el color a las celdas de la diagonal de izquierda a derecha
                /* ------------------------------------------------------------------------- */
                DgvTabla2.Rows[i].Cells[i].Style.BackColor = Color.Blue;
                SumaDiagonal1 += int.Parse(DgvTabla2.Rows[i].Cells[i].Value.ToString());

                /* ------------------------------------------------------------------------- */
                // Se le asigna el color a las celdas de la diagonal de derecha a izquierda
                /* ------------------------------------------------------------------------- */
                DgvTabla2.Rows[i].Cells[ColCount - i - 1].Style.BackColor = Color.Magenta;
                SumaDiagonal2 += int.Parse(DgvTabla2.Rows[i].Cells[ColCount - i - 1].Value.ToString());
            }

            /* ------------------------------------------------------------------------- */
            // Se le asignan los valores a los inputs y se les da su color respectivo
            /* ------------------------------------------------------------------------- */
            TextBoxSalida4.Text = $"{SumaDiagonal1}";
            TextBoxSalida4.BackColor = Color.Blue;
            TextBoxSalida5.Text = $"{SumaDiagonal2}";
            TextBoxSalida5.BackColor = Color.Magenta;
        }
    }
}
