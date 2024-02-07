using System;
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
        // TextBox del numero 1
        /* ------------------------------------------------------------------------- */
        private void TextBoxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // TextBox del numero 2
        /* ------------------------------------------------------------------------- */
        private void TextBoxNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DlgMesaParcticas1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PnlDerecho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
