using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // RRDE. 02/03/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgMesaSoundboard : Form
    {
        /* ------------------------------------------------------------------------- */
        // Atributos
        /* ------------------------------------------------------------------------- */
        SoundPlayer CurrentSound;

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaSoundboard()
        {
            /* ------------------------------------------------------------------------- */
            // Inicializamos los componentes
            /* ------------------------------------------------------------------------- */
            InitializeComponent();

            /* ------------------------------------------------------------------------- */
            // Cambiamos los labels de los botones
            /* ------------------------------------------------------------------------- */
            BtnSound1.Text = "Yowaimo";
            BtnSound2.Text = "Noooo mi compa";
            BtnSound3.Text = "Hey kitty";
            BtnSound4.Text = "Waiwaiwai";
            BtnSound5.Text = "Un video más";
            BtnSound6.Text = "Salamaleco";
            BtnSound7.Text = "Plin plam";
            BtnSound8.Text = "Mmmm";
            BtnSound9.Text = "Mala noticia";
            BtnSound10.Text = "Fak";
            BtnSound11.Text = "Donde está el Titan Speackerman";
            BtnSound12.Text = "Donde dice esa mmada";

            /* ------------------------------------------------------------------------- */
            // Eventos
            /* ------------------------------------------------------------------------- */
            DlgMesaSoundboard_Resize(null, null);
        }

        private void DlgMesaSoundboard_Resize(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int[] Window = { Width, Height },
                  Title = { LblTitle.Width, LblTitle.Height },
                  Btn = { BtnSound1.Width, BtnSound1.Height },
                  Stop = { BtnStop.Width, BtnStop.Height };
            int Top;
            /* ------------------------------------------------------------------------- */
            // Centramos el título
            /* ------------------------------------------------------------------------- */
            LblTitle.Location = new Point((Window[0] - Title[0]) / 2, 10);
            
            /* ------------------------------------------------------------------------- */
            // Posicionamos el botón de stop abajo a la izquierda con una separación de 10
            /* ------------------------------------------------------------------------- */
            BtnStop.Location = new Point(10, Window[1] - Stop[1] - 50);

            /* ------------------------------------------------------------------------- */
            // Si el ancho de la ventana es mayor a 1010, creamos una fila de 4 botones
            // que esten centrados que tengan una separación a los lados de 10
            // Si no, creamos una fila de 2 botones que esten centrados que tengan una
            // separación a los lados de 10
            if (Window[0] > 1010)
            {
                Top = Window[1] / 2 - (Btn[1] * 3 + 20) / 2;
                /* ------------------------------------------------------------------------- */
                // Creamos una fila de 4 botones que esten centrados que tengan una separación a los lados de 10
                /* ------------------------------------------------------------------------- */
                BtnSound1.Location = new Point((Window[0] - (Btn[0] * 4 + 30)) / 2, Top);
                BtnSound2.Location = new Point(BtnSound1.Location.X + Btn[0] + 10, Top);
                BtnSound3.Location = new Point(BtnSound2.Location.X + Btn[0] + 10, Top);
                BtnSound4.Location = new Point(BtnSound3.Location.X + Btn[0] + 10, Top);
                BtnSound5.Location = new Point((Window[0] - (Btn[0] * 4 + 30)) / 2, Top + Btn[1] + 10);
                BtnSound6.Location = new Point(BtnSound5.Location.X + Btn[0] + 10, Top + Btn[1] + 10);
                BtnSound7.Location = new Point(BtnSound6.Location.X + Btn[0] + 10, Top + Btn[1] + 10);
                BtnSound8.Location = new Point(BtnSound7.Location.X + Btn[0] + 10, Top + Btn[1] + 10);
                BtnSound9.Location = new Point((Window[0] - (Btn[0] * 4 + 30)) / 2, Top + Btn[1] * 2 + 20);
                BtnSound10.Location = new Point(BtnSound9.Location.X + Btn[0] + 10, Top + Btn[1] * 2 + 20);
                BtnSound11.Location = new Point(BtnSound10.Location.X + Btn[0] + 10, Top + Btn[1] * 2 + 20);
                BtnSound12.Location = new Point(BtnSound11.Location.X + Btn[0] + 10, Top + Btn[1] * 2 + 20);
            } else
            {
                /* ------------------------------------------------------------------------- */
                // Ajustamos el top para que los botones esten más arriba
                /* ------------------------------------------------------------------------- */
                Top = Window[1] / 2 - (Btn[1] * 6 + 60) / 2;

                /* ------------------------------------------------------------------------- */
                // Creamos una fila de 2 botones que esten centrados que tengan una separación a los lados de 10
                /* ------------------------------------------------------------------------- */
                BtnSound1.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top);
                BtnSound2.Location = new Point(BtnSound1.Location.X + Btn[0] + 10, Top);
                BtnSound3.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] + 10);
                BtnSound4.Location = new Point(BtnSound3.Location.X + Btn[0] + 10, Top + Btn[1] + 10);
                BtnSound5.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 2 + 20);
                BtnSound6.Location = new Point(BtnSound5.Location.X + Btn[0] + 10, Top + Btn[1] * 2 + 20);
                BtnSound7.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 3 + 30);
                BtnSound8.Location = new Point(BtnSound7.Location.X + Btn[0] + 10, Top + Btn[1] * 3 + 30);
                BtnSound9.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 4 + 40);
                BtnSound10.Location = new Point(BtnSound9.Location.X + Btn[0] + 10, Top + Btn[1] * 4 + 40);
                BtnSound11.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 5 + 50);
                BtnSound12.Location = new Point(BtnSound11.Location.X + Btn[0] + 10, Top + Btn[1] * 5 + 50);
            }
        }

        private void BtnSound1_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\Yowaimo.wav");
            CurrentSound.Play();
        }

        private void BtnSound2_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\NooooMiCompa.wav");
            CurrentSound.Play();
        }

        private void BtnSound3_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\HeyKitty.wav");
            CurrentSound.Play();
        }

        private void BtnSound4_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloWaiwaiwai.wav");
            CurrentSound.Play();
        }

        private void BtnSound5_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloUnVideoMas.wav");
            CurrentSound.Play();
        }

        private void BtnSound6_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloSalamaleco.wav");
            CurrentSound.Play();
        }

        private void BtnSound7_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloPlinPlam.wav");
            CurrentSound.Play();
        }

        private void BtnSound8_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloMmmm.wav");
            CurrentSound.Play();
        }

        private void BtnSound9_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloMalaNoticia.wav");
            CurrentSound.Play();
        }

        private void BtnSound10_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloFak.wav");
            CurrentSound.Play();
        }

        private void BtnSound11_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DondeEstaElTitanSpeackerman.wav");
            CurrentSound.Play();
        }

        private void BtnSound12_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DondeDiceEsaMmada.wav");
            CurrentSound.Play();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            CurrentSound.Stop();
            CurrentSound = null;
        }
    }
}
