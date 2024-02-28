using System;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Menú principal del proyecto Programación Estructurada 24A
    // RRDE. 29/01/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgPrincipal : Form
    {
        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 1
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas1_Click(object sender, EventArgs e)
        {
            DlgMesaParcticas1 dlgMesaParcticas1 = new DlgMesaParcticas1();

            dlgMesaParcticas1.ShowDialog();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 2
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas2_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 3
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas3_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 4
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas4_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 5
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas5_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 6
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas6_Click(object sender, EventArgs e)
        {

        }

        /* ------------------------------------------------------------------------- */
        // Metodos inecesarios (de momento)
        /* ------------------------------------------------------------------------- */
        private void DlgPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
