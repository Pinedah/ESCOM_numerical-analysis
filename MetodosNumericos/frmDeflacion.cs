using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class frmDeflacion : Form
    {
        public frmDeflacion()
        {
            InitializeComponent();
            
            lblX.Visible = false;
            txtCoef.Visible = false;    
            btn_coeficientes.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            numMaxIterMu.Visible = false;
            ErrMaxMu.Visible = false;
            txt_p0.Visible = false;
            txt_p1.Visible = false;
            txt_p2.Visible = false;
            btn_calcular.Visible = false;
        }

        int grado = 0, contador = 0;
        List<Complex> coeficientes = new List<Complex>();

        private void btn_grado_Click(object sender, EventArgs e)
        {
            grado = int.Parse(gradoPol.Text);
            lblX.Visible = true;
            txtCoef.Visible = true;
            btn_coeficientes.Visible = true;

            lblX.Text = "X^0";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Complex[] arr = coeficientes.ToArray();
            int maxIter = int.Parse(numMaxIterMu.Text);
            double errMax = double.Parse(ErrMaxMu.Text);
            double p0 = double.Parse(txt_p0.Text);
            double p1 = double.Parse(txt_p1.Text);
            double p2 = double.Parse(txt_p2.Text);

            MetodosSolEc metodosSolEc = new MetodosSolEc();
            metodosSolEc.numMaxIter = maxIter;
            metodosSolEc.errorMaximo = errMax;
            metodosSolEc.deflacion(p0, p1, p2, arr, ref this.dgv_result);
        }

        private void btn_coeficientes_Click(object sender, EventArgs e)
        {
            if(contador == grado)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                numMaxIterMu.Visible = true;
                ErrMaxMu.Visible = true;
                txt_p0.Visible = true;
                txt_p1.Visible = true;
                txt_p2.Visible = true;
                btn_calcular.Visible = true;
            }
            else
            {
                lblX.Text = "X^" + (contador + 1);
                Console.WriteLine(txtCoef.Text);
                coeficientes.Add(new Complex(double.Parse(txtCoef.Text), 0));
                txtCoef.Text = "";
                contador++;
            }
        }

    }
}
