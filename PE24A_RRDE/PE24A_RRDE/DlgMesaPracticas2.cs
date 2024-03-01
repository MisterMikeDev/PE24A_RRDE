using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Mesa de trabajo del proyecto Programación Estructurada 24A
    // RRDE. 28/02/2024.
    /* ------------------------------------------------------------------------- */
    public partial class DlgMesaPracticas2 : Form
    {
        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas2()
        {
            InitializeComponent();
            /* ------------------------------------------------------------------------- */
            // Inicializar la hora actual
            /* ------------------------------------------------------------------------- */
            SetCurrentTime();

            /* ------------------------------------------------------------------------- */
            // Actualizar la hora cada segundo
            /* ------------------------------------------------------------------------- */
            SetTimeout(SetCurrentTime, 500);

            /* ------------------------------------------------------------------------- */
            // Centrar los componentes en la ventana
            /* ------------------------------------------------------------------------- */
            DlgMesaPracticas2_Resize(null, null);
        }

        private void SetCurrentTime()
        {
            /* ------------------------------------------------------------------------- */
            // Actualizar la hora actual
            /* ------------------------------------------------------------------------- */
            DateTime CurrentDate = DateTime.Now;
            LblCurrentTime.Text = CurrentDate.ToString("HH:mm");
            LblCurrentDate.Text = CurrentDate.ToString("dddd, dd 'de' MMMM");
        }

        public void SetTimeout(Action action, int timeout)
        {
            /* ------------------------------------------------------------------------- */
            // Actualizar la hora cada segundo
            /* ------------------------------------------------------------------------- */
            Timer timer = new Timer();
            timer.Tick += new EventHandler((object sender, EventArgs e) => action());
            timer.Interval = timeout;
            timer.Start();
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar posicion de los controles al cambiar el tamaño de la ventana
        /* ------------------------------------------------------------------------- */
        private void DlgMesaPracticas2_Resize(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------------------- */
            // Variables
            /* ------------------------------------------------------------------------- */
            int[] Window = { Width, Height },
                  Time = { LblCurrentTime.Width, LblCurrentTime.Height },
                  Date = { LblCurrentDate.Width, LblCurrentDate.Height },
                  SpotifyWidget = { PicSpotify.Width, PicSpotify.Height },
                  BateryWidget = { PicBatery.Width, PicBatery.Height };

            /* ------------------------------------------------------------------------- */
            // Centrar la hora actual horizontalmente al centro de la ventana
            /* ------------------------------------------------------------------------- */
            LblCurrentTime.Location = new Point((Window[0] - Time[0]) / 2, Time[1]);

            /* ------------------------------------------------------------------------- */
            // Centrar la fecha actual abajo de la hora actual
            /* ------------------------------------------------------------------------- */
            LblCurrentDate.Location = new Point((Window[0] - Date[0]) / 2, Time[1] * 2);

            /* ------------------------------------------------------------------------- */
            // Colocar el widget de Spotify abajo a la izquierda
            /* ------------------------------------------------------------------------- */
            PicSpotify.Location = new Point(10, Window[1] - SpotifyWidget[1] - 50);

            /* ------------------------------------------------------------------------- */
            // Coloca widget del wifi y la batería en la esquina inferior derecha
            /* ------------------------------------------------------------------------- */
            PicBatery.Location = new Point(Window[0] - BateryWidget[0] * 2, Window[1] - BateryWidget[1] * 3);
            PicWifi.Location = new Point(Window[0] - BateryWidget[0] * 4, Window[1] - BateryWidget[1] * 3);
        }
    }
}
