using System;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(
                new DlgPrincipal()
            );
        }
    }
}