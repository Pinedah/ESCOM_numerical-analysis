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

        private void metodoDeMullerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuller f = new frmMuller();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void metodoDeLaSecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecante f = new frmSecante();
            f.Show();
            f.WindowState = FormWindowState.Normal;

        }

        private void metodoDeNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewton f = new frmNewton();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void métodoDePuntoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuntoFijo f = new frmPuntoFijo();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void métodoDeLaFalsaPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFalsaPos f = new frmFalsaPos();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void métodoDeSteffensenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSteffensen f = new frmSteffensen();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void métodoDeBiseccionAitkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiseccion_Aitken f = new frmBiseccion_Aitken();
            f.Show();
            f.WindowState = FormWindowState.Normal;    
        }
    }
}
