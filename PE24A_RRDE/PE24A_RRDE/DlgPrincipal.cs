using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE24A_RRDE
{
    public partial class DlgPrincipal : Form
    {
        public DlgPrincipal()
        {
            InitializeComponent();
        }

        private void BtnHelloWorld_Click(object sender, EventArgs e)
        {
            string Message = "mi primera chamba";

            if (ChbHello.Checked)
            {
                Message = "mi segunda chamba";
            }

            MessageBox.Show($"Hola esta es {Message}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DlgPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
