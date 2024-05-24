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
        // Variables
        /* ------------------------------------------------------------------------- */
        int PointsCounter = 0, r, g, b, a;
        Brush CurrentColor = Brushes.Red;
        Color IncrementalColor = Color.Red;
        Random rand = new Random();

        /* ------------------------------------------------------------------------- */
        // Constructor
        /* ------------------------------------------------------------------------- */
        public DlgMesaPracticas2()
        {
            InitializeComponent();

            /* ------------------------------------------------------------------------- */
            // Configuración de la ventana
            /* ------------------------------------------------------------------------- */
            this.MinimumSize = new System.Drawing.Size(600, 400);

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

        /* ------------------------------------------------------------------------- */
        // Setea la hora actual
        /* ------------------------------------------------------------------------- */
        private void SetCurrentTime()
        {
            /* ------------------------------------------------------------------------- */
            // Actualizar la hora actual
            /* ------------------------------------------------------------------------- */
            DateTime CurrentDate = DateTime.Now;
            LblCurrentTime.Text = CurrentDate.ToString("HH:mm:ss");
            LblCurrentDate.Text = CurrentDate.ToString("dddd, dd 'de' MMMM");
        }

        /* ------------------------------------------------------------------------- */
        // Crea el intervalo con una custom action
        /* ------------------------------------------------------------------------- */
        private void SetTimeout(Action action, int timeout)
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
                  BateryWidget = { PicBatery.Width, PicBatery.Height },
                  CanvasBtn = { BtnShowCanvas.Width, BtnShowCanvas.Height },
                  ColorBtn = { BtnColorGreen.Width, BtnColorGreen.Height },
                  SquareBtn = { BtnSquare.Width, BtnSquare.Height };
            int BtnsWidth = ColorBtn[0] * 8 + 10 * 7,
                BtnsX = (PnlColorChoices.Width - BtnsWidth) / 2,
                BtnsY = (PnlColorChoices.Height - ColorBtn[1]) / 2,
                MediaQuery = 680;

            if (MediaQuery > Window[0])
            {
                MessageBox.Show("La ventana es muy pequeña para mostrar todos los componentes");
                this.Width = MediaQuery + 100;
            }

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

            /* ------------------------------------------------------------------------- */
            // Colocar el botón del canvas
            /* ------------------------------------------------------------------------- */
            BtnShowCanvas.Location = new Point((Window[0] - CanvasBtn[0]) / 2, Window[1] - CanvasBtn[1] - 50);

            /* ------------------------------------------------------------------------- */
            // Se coloca el contador de puntos al  lado derecho del botón.
            /* ------------------------------------------------------------------------- */
            LblPointCounter.Location = new Point(BtnShowCanvas.Location.X + CanvasBtn[0] + 10, BtnShowCanvas.Location.Y);

            /* ------------------------------------------------------------------------- */
            // Colocar el botón del canvas
            /* ------------------------------------------------------------------------- */
            BtnSquare.Location = new Point(BtnShowCanvas.Location.X - SquareBtn[0], BtnShowCanvas.Location.Y);

            /* ------------------------------------------------------------------------- */
            // Colocar el panel del canvas
            /* ------------------------------------------------------------------------- */
            BtnColorGreen.Location = new Point(BtnsX, BtnsY);
            BtnColorYellow.Location = new Point(BtnsX + ColorBtn[0] + 10, BtnsY);
            BtnColorOrange.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 2, BtnsY);
            BtnColorRed.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 3, BtnsY);
            BtnColorPink.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 4, BtnsY);
            BtnColorBlue.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 5, BtnsY);
            BtnColorCyan.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 6, BtnsY);
            BtnColorBlack.Location = new Point(BtnsX + (ColorBtn[0] + 10) * 7, BtnsY);
        }

        /* ------------------------------------------------------------------------- */
        // Botón para mostrar el canvas
        /* ------------------------------------------------------------------------- */
        private void BtnShowCanvas_Click(object sender, EventArgs e)
        {
            PointsCounter = 0;
            LblPointCounter.Text = $"{PointsCounter}";
            PnlCanvas.Visible = !PnlCanvas.Visible;
            PnlColorChoices.Visible = PnlCanvas.Visible;
            BtnSquare.Visible = PnlCanvas.Visible;
            LblPointCounter.Visible = PnlCanvas.Visible;
                
            if (PnlCanvas.Visible) PnlCentral.BackgroundImage = null;
            else PnlCentral.BackgroundImage = Properties.Resources.bgPractica2;
        }

        /* ------------------------------------------------------------------------- */
        // Dibuja muchos cuadrados al centro de la ventana
        /* ------------------------------------------------------------------------- */
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            int x0 = (PnlCanvas.Width - 10) / 2,
                y0 = (PnlCanvas.Height - 10) / 2;
            DrawMultipleSquares(x0, y0, 800);
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar en el canvas
        /* ------------------------------------------------------------------------- */
        private void PnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Draw(e, 25);
            else if (e.Button == MouseButtons.Right) Erase(e, 50);
            else if (e.Button == MouseButtons.Middle) DrawMultipleSquares(e.X, e.Y, 50);
            else if (e.Button == MouseButtons.XButton1) Erase(e, 100);
            else if (e.Button == MouseButtons.XButton2) Draw(e, 100);
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar un punto en el canvas
        /* ------------------------------------------------------------------------- */
        private void Draw(MouseEventArgs e, int diameter)
        {
            Graphics g = PnlCanvas.CreateGraphics();
            g.FillEllipse(
                CurrentColor,
                e.X - diameter / 2,
                e.Y - diameter / 2,
                diameter,
                diameter
            );
            PointsCounter++;
            LblPointCounter.Text = $"{PointsCounter}";
        }

        /* ------------------------------------------------------------------------- */
        // Borrar un punto en el canvas
        /* ------------------------------------------------------------------------- */
        private void Erase(MouseEventArgs e, int diameter)
        {
            Graphics g = PnlCanvas.CreateGraphics();
            g.FillEllipse(
                Brushes.White,
                e.X - diameter / 2,
                e.Y - diameter / 2,
                diameter,
                diameter
            );
        }

        /* ------------------------------------------------------------------------- */
        // Dibuja un cuadrado
        /* ------------------------------------------------------------------------- */
        private void DrawSquare(int x, int y, int lado)
        {
            Graphics g = PnlCanvas.CreateGraphics();
            Random random = new Random();
            IncrementalCurrentColor();
            Color color = IncrementalColor;
            Pen pen = new Pen(color, random.Next(1, 1));
            g.DrawLine(pen, x, y, x + lado, y);
            g.DrawLine(pen, x + lado, y, x + lado, y + lado);
            g.DrawLine(pen, x + lado, y + lado, x, y + lado);
            g.DrawLine(pen, x, y + lado, x, y);
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a verde
        /* ------------------------------------------------------------------------- */
        private void BtnColorGreen_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Green;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a amarillo
        /* ------------------------------------------------------------------------- */
        private void BtnColorYellow_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Yellow;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a naranja
        /* ------------------------------------------------------------------------- */
        private void BtnColorOrange_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Orange;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a rojo
        /* ------------------------------------------------------------------------- */
        private void BtnColorRed_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Red;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a rosa
        /* ------------------------------------------------------------------------- */
        private void BtnColorPink_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Pink;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a azul
        /* ------------------------------------------------------------------------- */
        private void BtnColorBlue_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Blue;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a cian
        /* ------------------------------------------------------------------------- */
        private void BtnColorCyan_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Cyan;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color del pincel a negro
        /* ------------------------------------------------------------------------- */
        private void BtnColorBlack_Click(object sender, EventArgs e)
        {
            CurrentColor = Brushes.Black;
        }

        /* ------------------------------------------------------------------------- */
        // Dibuja los cuadrados de manera parametrizada
        /* ------------------------------------------------------------------------- */
        private void DrawMultipleSquares(int x, int y, int count)
        {
            int lastSize = 10,
                squareCounter = 0;

            for (int i = 0; i < count; i++)
            {
                DrawSquare(x - (lastSize) / 2, y - (lastSize) / 2, lastSize);
                lastSize += 3;
                //(int)Math.Pow(squereCounter + 2, 2) / 30 + 5;
                squareCounter++;
            }
        }

        /* ------------------------------------------------------------------------- */
        // Actualiza el valor de current color
        /* ------------------------------------------------------------------------- */
        private Color IncrementalCurrentColor()
        {
            r = IncrementalColor.R;
            g = IncrementalColor.G;
            b = IncrementalColor.B;
            a = IncrementalColor.A;

            if (r == 255 && g < 255 && b == 0) g += 5;
            else if (g == 255 && r > 0 && b == 0) r -= 5;
            else if (g == 255 && b < 255 && r == 0) b += 5;
            else if (b == 255 && g > 0 && r == 0) g -= 5;
            else if (b == 255 && r < 255 && g == 0) r += 5;
            else if (r == 255 && b > 0 && g == 0) b -= 5;

            IncrementalColor = Color.FromArgb(a, r, g, b);

            return IncrementalColor;
        }
    }
}
