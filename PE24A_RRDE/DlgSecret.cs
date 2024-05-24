using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    /* ------------------------------------------------------------------------- */
    // Menú secreto del proyecto Programación Estructurada 24A
    // RRDE. 15/03/2024.
    // Intento de reacración de un Breakout.
    /* ------------------------------------------------------------------------- */
    public partial class DlgSecret : Form
    {
        /* ------------------------------------------------------------------------- */
        // Variables
        /* ------------------------------------------------------------------------- */
        Random random = new Random();
        Color currentColor = Color.Red;
        int canvasWidth = 100,
            canvasHeight = 100,
            ballDiameter = 60,
            ballSpeed = 10,
            ballX = 0,
            ballY = 0,
            dx = 0,
            dy = 0,
            r,
            g,
            b,
            a;

        /* ------------------------------------------------------------------------- */
        // Constructor de la clase
        /* ------------------------------------------------------------------------- */
        public DlgSecret()
        {
            InitializeComponent();

            // Evento de cambio de tamaño del formulario.
            DlgSecret_Resize(null, null);

            // Inicializar las variables.
            canvasWidth = PnlCanvas.Width;
            canvasHeight = PnlCanvas.Height;
            ballX = random.Next(0, canvasWidth - ballDiameter);
            ballY = random.Next(0, canvasHeight - ballDiameter);
            dx = ballSpeed;
            dy = ballSpeed;

            // Agregamos el evento de cierre.
            this.FormClosing += (s, e) => onClose();

            // Crear el bucle
            CreateLoop(1);
        }

        /* ------------------------------------------------------------------------- */
        // Crear el bucle del juego y usa las funciones de dibujo.
        /* ------------------------------------------------------------------------- */
        private void CreateLoop(float framesPerSeconds)
        {
            Timer gameTimer = new Timer();
            gameTimer.Interval = (int)framesPerSeconds;
            gameTimer.Tick += new EventHandler(Loop);
            gameTimer.Start();
        }

        /* ------------------------------------------------------------------------- */
        // Bucle del canvas
        /* ------------------------------------------------------------------------- */
        private void Loop(object sender, EventArgs e)
        {
            DrawBall();
            BallMovment();
        }

        /* ------------------------------------------------------------------------- */
        // Dibujar una bola en el canvas.
        /* ------------------------------------------------------------------------- */
        private void DrawBall()
        {
            try
            {
                if (PnlCanvas == null) return;
                Graphics g = PnlCanvas?.CreateGraphics();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                IncrementalColor();
                SolidBrush brush = new SolidBrush(currentColor);
                g.FillEllipse(brush, ballX, ballY, ballDiameter, ballDiameter);
            }
            catch { }
        }

        private void BallMovment()
        {
            if (PnlCanvas == null) return;

            if (ballX < 0 || ballX > canvasWidth - ballDiameter)
            {
                dx = -dx;
            }

            if (ballY < 0 || ballY > canvasHeight - ballDiameter)
            {
                dy = -dy;
            }

            ballX += dx;
            ballY += dy;
        }

        /* ------------------------------------------------------------------------- */
        // Cambiar el color de la bola.
        /* ------------------------------------------------------------------------- */
        private Color IncrementalColor()
        {
            r = currentColor.R;
            g = currentColor.G;
            b = currentColor.B;
            a = currentColor.A;

            if (r == 255 && g < 255 && b == 0) g += 5; 
            else if (g == 255 && r > 0 && b == 0) r -= 5;
            else if (g == 255 && b < 255 && r == 0) b += 5;
            else if (b == 255 && g > 0 && r == 0) g -= 5;
            else if (b == 255 && r < 255 && g == 0) r += 5;
            else if (r == 255 && b > 0 && g == 0) b -= 5;

            currentColor = Color.FromArgb(a, r, g, b);

            return currentColor;
        }

        /* ------------------------------------------------------------------------- */
        // Evento de cambio de tamaño del formulario.
        /* ------------------------------------------------------------------------- */
        private void DlgSecret_Resize(object sender, EventArgs e)
        {
            canvasWidth = PnlCanvas.Width;
            canvasHeight = PnlCanvas.Height;
        }

        /* ------------------------------------------------------------------------- */
        // Evento de cierre para evitar errores.
        /* ------------------------------------------------------------------------- */
        private void onClose()
        {
            PnlCanvas.Dispose();
            
            // Liberar recursos.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            // Salir.
            Application.Exit();
        }
    }
}
