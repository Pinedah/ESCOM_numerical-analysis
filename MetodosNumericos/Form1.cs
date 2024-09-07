using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void metodoDeBiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiseccion f = new frmBiseccion();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        
    }
}
