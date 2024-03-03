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

            /* ------------------------------------------------------------------------- */
            // Se actualiza la posicion de todos los componentes al momento de iniciar
            // el componente principal
            /* ------------------------------------------------------------------------- */
            DlgPrincipal_Resize(null, null);
        }

        /* ------------------------------------------------------------------------- */
        // Resize Event Listener
        /* ------------------------------------------------------------------------- */
        private void DlgPrincipal_Resize(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int[] Window = { Width, Height },
                  Title = { TitleMain.Width, TitleMain.Height },
                  Logo = { UdgLogo.Width, UdgLogo.Height },
                  Name = { StudentName.Width, UdgLogo.Height },
                  Btn1 = { BtnMesaPracticas1.Width, BtnMesaPracticas1.Height },
                  Btn2 = { BtnMesaPracticas2.Width, BtnMesaPracticas2.Height },
                  Btn3 = { BtnMesaPracticas3.Width, BtnMesaPracticas3.Height },
                  Btn4 = { BtnMesaPracticas4.Width, BtnMesaPracticas4.Height },
                  Btn5 = { BtnMesaPracticas5.Width, BtnMesaPracticas5.Height },
                  Btn6 = { BtnMesaPracticas6.Width, BtnMesaPracticas6.Height };
            int MediaQuery = 720,
                Separation,
                Top;
            /* ------------------------------------------------------------------------- */
            // Center Title
            /* ------------------------------------------------------------------------- */
            TitleMain.Left = (Window[0] - Title[0]) / 2;
            TitleMain.Top = Title[1] / 2;

            /* ------------------------------------------------------------------------- */
            // Bottom Left Logo
            /* ------------------------------------------------------------------------- */
            UdgLogo.Left = 5;
            UdgLogo.Top = (Window[1] - Logo[1]) - 40;

            /* ------------------------------------------------------------------------- */
            // Bottom Right Name
            /* ------------------------------------------------------------------------- */
            StudentName.Left = Window[0] - Name[0] - 20;
            StudentName.Top = Window[1] - Name[1] + 50;

            /* ------------------------------------------------------------------------- */
            // Secret...
            /* ------------------------------------------------------------------------- */
            BtnSecret.Top = 10;
            BtnSecret.Left = 10;

            /* ------------------------------------------------------------------------- */
            // Sort Buttons
            /* ------------------------------------------------------------------------- */
            if (Window[0] > MediaQuery)
            {
                /* ------------------------------------------------------------------------- */
                // Se ponen los botones con altura normal
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas1.Height = 120;
                BtnMesaPracticas2.Height = 120;
                BtnMesaPracticas3.Height = 120;
                BtnMesaPracticas4.Height = 120;
                BtnMesaPracticas5.Height = 120;
                BtnMesaPracticas6.Height = 120;

                /* ------------------------------------------------------------------------- */
                // Se establecen las variables dinamicas de separacion y altura
                /* ------------------------------------------------------------------------- */
                Separation = (Window[0] - Btn1[0] - Btn2[0]) / 3;
                Top = ((Window[1] - Btn1[1]) / 2) - (Btn1[1] / 2);

                /* ------------------------------------------------------------------------- */
                // Se posicionan los tres primeros botones tanto en x como en y
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas1.Left = Separation;
                BtnMesaPracticas1.Top = Top;
                BtnMesaPracticas2.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas2.Top = Top - Btn1[1];
                BtnMesaPracticas3.Left = Window[0] - Separation - Btn1[0];
                BtnMesaPracticas3.Top = Top;

                /* ------------------------------------------------------------------------- */
                // Se baja la altura donde se ponen los siguientes tres botones
                /* ------------------------------------------------------------------------- */
                Top = ((Window[1] - Btn1[1]) / 2) + Btn1[1];

                /* ------------------------------------------------------------------------- */
                // Se posicionan los tres primeros botones tanto en x como en y
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas4.Left = Separation;
                BtnMesaPracticas4.Top = Top;
                BtnMesaPracticas5.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas5.Top = Top + Btn1[1];
                BtnMesaPracticas6.Left = Window[0] - Separation - Btn1[0];
                BtnMesaPracticas6.Top = Top;
            }
            else
            {

                TitleMain.Text = "Programación\nEstructurada 2024";
                /* ------------------------------------------------------------------------- */
                // Se establecen las variables dinamicas de separacion y altura
                /* ------------------------------------------------------------------------- */
                Top = Title[1] * 2;

                /* ------------------------------------------------------------------------- */
                // Se centran todos los botones en forma de columna
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas1.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas2.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas3.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas4.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas5.Left = (Window[0] - Btn1[0]) / 2;
                BtnMesaPracticas6.Left = (Window[0] - Btn1[0]) / 2;

                /* ------------------------------------------------------------------------- */
                // Se ponen los botones con altura pequeña
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas1.Height = Btn1[1] / 2;
                BtnMesaPracticas2.Height = Btn2[1] / 2;
                BtnMesaPracticas3.Height = Btn3[1] / 2;
                BtnMesaPracticas4.Height = Btn4[1] / 2;
                BtnMesaPracticas5.Height = Btn5[1] / 2;
                BtnMesaPracticas6.Height = Btn6[1] / 2;

                /* ------------------------------------------------------------------------- */
                // Se posicionan los botones en el eje y con su respectuva separacion
                // la cual es de 15 por cada boton
                /* ------------------------------------------------------------------------- */
                BtnMesaPracticas1.Top = Top;
                BtnMesaPracticas2.Top = Top + Btn1[1] + 15;
                BtnMesaPracticas3.Top = Top + Btn2[1] * 2 + 30;
                BtnMesaPracticas4.Top = Top + Btn3[1] * 3 + 45;
                BtnMesaPracticas5.Top = Top + Btn4[1] * 4 + 60;
                BtnMesaPracticas6.Top = Top + Btn5[1] * 5 + 75;
            }
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 1
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas1_Click_1(object sender, EventArgs e)
        {
            DlgMesaPracticas1 dlgMesaParcticas1 = new DlgMesaPracticas1();

            dlgMesaParcticas1.ShowDialog();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 2
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas2_Click(object sender, EventArgs e)
        {
            DlgMesaPracticas2 dlgMesaPracticas2 = new DlgMesaPracticas2();
            dlgMesaPracticas2.ShowDialog();
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 3
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente...");
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 4
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente...");
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 5
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente...");
        }

        /* ------------------------------------------------------------------------- */
        // Botón de activación de Mes de Prácticas 6
        /* ------------------------------------------------------------------------- */
        private void BtnMesaPracticas6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente...");
        }

        /* ------------------------------------------------------------------------- */
        // Metodos inecesarios (de momento)
        /* ------------------------------------------------------------------------- */
        private void DlgPrincipal_Load(object sender, EventArgs e) {}

        /* ------------------------------------------------------------------------- */
        // Soundboard
        /* ------------------------------------------------------------------------- */
        private void BtnSecret_Click(object sender, EventArgs e)
        {
            DlgMesaSoundboard dlgMesaSoundboard = new DlgMesaSoundboard();
            dlgMesaSoundboard.ShowDialog();
        }
    }
}
