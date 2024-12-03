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
    public partial class frmMetodoDeEuler : Form
    {
        public frmMetodoDeEuler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tf_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float condicion, h, error;

            condicion = float.Parse(tf_condicion.Text);
            h = float.Parse(tf_h.Text);
            error = float.Parse(tf_error.Text);

            EcuacionesDiferenciales ed = new EcuacionesDiferenciales();

            float res = ed.metodoDeEuler(condicion, h, error);
            tf_res.Text = res.ToString();
        }

        private void tf_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tf_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMetodoDeEuler_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tf_error_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
