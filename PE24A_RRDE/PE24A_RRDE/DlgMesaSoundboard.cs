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
            BtnSound13.Text = "Capitan torta 🤙";
            BtnSound14.Text = "Δ 1";
            BtnSound15.Text = "El Zapato";
            BtnSound16.Text = "A sorry everybody\nfollows me";

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
                /* ------------------------------------------------------------------------- */
                // Centramos verticalmente los botones con proporcion tanto arriba como abajo 
                /* ------------------------------------------------------------------------- */
                Top = Window[1] / 2 - (Btn[1] * 4 + 30) / 2;

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
                BtnSound13.Location = new Point((Window[0] - (Btn[0] * 4 + 30)) / 2, Top + Btn[1] * 3 + 30);
                BtnSound14.Location = new Point(BtnSound13.Location.X + Btn[0] + 10, Top + Btn[1] * 3 + 30);
                BtnSound15.Location = new Point(BtnSound14.Location.X + Btn[0] + 10, Top + Btn[1] * 3 + 30);
                BtnSound16.Location = new Point(BtnSound15.Location.X + Btn[0] + 10, Top + Btn[1] * 3 + 30);

            }
            else
            {
                /* ------------------------------------------------------------------------- */
                // Ajustamos el top para que los botones esten más arriba
                /* ------------------------------------------------------------------------- */
                Top = (Window[1] / 2 - (Btn[1] * 8 + 70) / 2) + 10;

                /* ------------------------------------------------------------------------- */
                // Ajustamo el posicionamiento del título
                /* ------------------------------------------------------------------------- */
                LblTitle.Location = new Point((Window[0] - Title[0]) / 2, 0);

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
                BtnSound13.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 6 + 60);
                BtnSound14.Location = new Point(BtnSound13.Location.X + Btn[0] + 10, Top + Btn[1] * 6 + 60);
                BtnSound15.Location = new Point((Window[0] - (Btn[0] * 2 + 10)) / 2, Top + Btn[1] * 7 + 70);
                BtnSound16.Location = new Point(BtnSound15.Location.X + Btn[0] + 10, Top + Btn[1] * 7 + 70);
            }
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 1
        /* ------------------------------------------------------------------------- */
        private void BtnSound1_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\Yowaimo.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 2
        /* ------------------------------------------------------------------------- */
        private void BtnSound2_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\NooooMiCompa.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 3
        /* ------------------------------------------------------------------------- */
        private void BtnSound3_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\HeyKitty.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 4
        /* ------------------------------------------------------------------------- */
        private void BtnSound4_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloWaiwaiwai.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 5
        /* ------------------------------------------------------------------------- */
        private void BtnSound5_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloUnVideoMas.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 6
        /* ------------------------------------------------------------------------- */
        private void BtnSound6_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloSalamaleco.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 7
        /* ------------------------------------------------------------------------- */
        private void BtnSound7_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloPlinPlam.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 8
        /* ------------------------------------------------------------------------- */
        private void BtnSound8_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloMmmm.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 9
        /* ------------------------------------------------------------------------- */
        private void BtnSound9_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloMalaNoticia.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 10
        /* ------------------------------------------------------------------------- */
        private void BtnSound10_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloFak.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 11
        /* ------------------------------------------------------------------------- */
        private void BtnSound11_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DondeEstaElTitanSpeackerman.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 12
        /* ------------------------------------------------------------------------- */
        private void BtnSound12_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DondeDiceEsaMmada.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 13
        /* ------------------------------------------------------------------------- */
        private void BtnSound13_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\CapitanTorta.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 14
        /* ------------------------------------------------------------------------- */
        private void BtnSound14_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\Delta1.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 15
        /* ------------------------------------------------------------------------- */
        private void BtnSound15_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\ElZapato.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Sonido 16
        /* ------------------------------------------------------------------------- */
        private void BtnSound16_Click(object sender, EventArgs e)
        {
            CurrentSound = new SoundPlayer(@"C:\Dev\learning-csharp\PE24A_RRDE\PE24A_RRDE\Resources\Soundboard\DonPolloAsorry.wav");
            CurrentSound.Play();
        }

        /* ------------------------------------------------------------------------- */
        // Detener sonido
        /* ------------------------------------------------------------------------- */
        private void BtnStop_Click(object sender, EventArgs e)
        {
            CurrentSound.Stop();
            CurrentSound = null;
        }
    }
}
