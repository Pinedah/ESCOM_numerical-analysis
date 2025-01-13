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
            frmBiseccionAitken f = new frmBiseccionAitken();
            f.Show();
            f.WindowState = FormWindowState.Normal;    
        }

        private void métodoDeLaSecanteAitkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecanteAitken f = new frmSecanteAitken();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void deflaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeflacion f = new frmDeflacion();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void trapecioCompuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // metodo trapecio

            frmTrapecio f = new frmTrapecio();
            f.Show();
            f.WindowState = FormWindowState.Normal;

        }

        private void simpson13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // metodo simpson 1/3

            frmSimpson1_3 f = new frmSimpson1_3();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void simpson38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSimpson3_8 f = new frmSimpson3_8();
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trapecioDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrapecioDoble frmTrapecioDoble = new frmTrapecioDoble();
            frmTrapecioDoble.Show();
            frmTrapecioDoble.WindowState = FormWindowState.Normal;
        }

        private void integraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simpson13ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSimpson1_3Doble frmSimpson1_3Doble = new frmSimpson1_3Doble();
            frmSimpson1_3Doble.Show();
            frmSimpson1_3Doble.WindowState = FormWindowState.Normal;
        }

        private void newtonCottesN2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewton_Cottes frmNewton_Cottes = new frmNewton_Cottes();
            frmNewton_Cottes.Show();
            frmNewton_Cottes.WindowState = FormWindowState.Normal;
        }

        private void metodoDeRombergToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRomberg frmRomberg = new frmRomberg();
            frmRomberg.Show();
            frmRomberg.WindowState = FormWindowState.Normal;
        }

        private void cuadraturaAdaptivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadraturaAdaptiva frmCuadraturaAdaptiva = new frmCuadraturaAdaptiva();
            frmCuadraturaAdaptiva.Show();
            frmCuadraturaAdaptiva.WindowState = FormWindowState.Normal;
        }

        private void cuadraturaGaussianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadraturaGaussiana frmCuadraturaGaussiana = new frmCuadraturaGaussiana();
            frmCuadraturaGaussiana.Show();
            frmCuadraturaGaussiana.WindowState = FormWindowState.Normal;
        }

        private void metodoDeEulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoDeEuler frmMetodoDeEuler = new frmMetodoDeEuler();
            frmMetodoDeEuler.Show();
            frmMetodoDeEuler.WindowState = FormWindowState.Normal;
        }

        private void metodoDeTaylorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoDeTaylor frmMetodoDeTaylor = new frmMetodoDeTaylor();
            frmMetodoDeTaylor.Show();
            frmMetodoDeTaylor.WindowState = FormWindowState.Normal;
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminacionGaussianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminacionGaussiana frmEliminacionGaussiana = new frmEliminacionGaussiana();
            frmEliminacionGaussiana.Show();
            frmEliminacionGaussiana.WindowState = FormWindowState.Normal;
        }

        private void metodoDeRungeKuttaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRungeKutta4 frmMetodoRungeKutta = new frmRungeKutta4();
            frmMetodoRungeKutta.Show();
            frmMetodoRungeKutta.WindowState = FormWindowState.Normal;
        }

        private void metodoDeHeunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoDeHeun frmMetodoHeun = new frmMetodoDeHeun();
            frmMetodoHeun.Show();
            frmMetodoHeun.WindowState = FormWindowState.Normal;
        }

        private void sEDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSEDO frmsedo = new frmSEDO();
            frmsedo.Show();
            frmsedo.WindowState = FormWindowState.Normal;
        }

        private void puntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDerivada2p frm2 = new frmDerivada2p();
            frm2.Show();
            frm2.WindowState = FormWindowState.Normal;
        }

        private void puntosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDerivacion3 frm3 = new frmDerivacion3();
            frm3.Show();
            frm3.WindowState = FormWindowState.Normal;
        }

        private void puntosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDerivada4p frm4 = new frmDerivada4p();
            frm4.Show();
            frm4.WindowState = FormWindowState.Normal;
        }
    }
}
