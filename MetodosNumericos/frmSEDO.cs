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
    public partial class frmSEDO : Form
    {
        public frmSEDO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int grado, contador = 1;
        List<float> coeficientes = new List<float>();

        private void btn_coeficientes_Click(object sender, EventArgs e)
        {
            coeficientes.Add(float.Parse(txtCoef.Text));
            if (contador == grado)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                tf_a.Visible = true;
                tf_b.Visible = true;
                tf_n.Visible = true;
                btn_calcular.Visible = true;
                dgv_result.Visible = true;
            }
            else
            {
                int aux = contador;
                lblX.Text = "C.I. " + (aux + 1);
                txtCoef.Text = "";
                contador++;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float[] arr = coeficientes.ToArray();
            int n = int.Parse(tf_n.Text);
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);

            EcuacionesDiferenciales ecDif = new EcuacionesDiferenciales();
            ecDif.metodoRK4Sistema(a, b, n, grado,arr, ecDif.sistemaEcuaciones, ref this.dgv_result);
        }

        private void btn_grado_Click(object sender, EventArgs e)
        {
            grado = int.Parse(gradoPol.Text);
            lblX.Visible = true;
            txtCoef.Visible = true;
            btn_coeficientes.Visible = true;

            lblX.Text = "C.I. 1";
        }
    }
}
