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
    public partial class frmMetodoDeTaylor : Form
    {
        public frmMetodoDeTaylor()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tf_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tf_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {

            float condicion, a, b, n;
            float res;
            condicion = float.Parse(tf_condicion.Text);
            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);
            n = int.Parse(tf_n.Text);

            EcuacionesDiferenciales ecDif = new EcuacionesDiferenciales();

            res = ecDif.metodoDeTaylor(condicion, a, b, n, ref this.dgv_result);
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

        private void tf_condicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
