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
    public partial class frmBiseccion : Form
    {
        public frmBiseccion()
        {
            InitializeComponent();
        }

        private void frmBiseccion_Click(object sender, EventArgs e)
        {
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a, b, errorMax;
            int numMaxIte;
            bool res;

            a = double.Parse(tf_a.Text);
            b = double.Parse(tf_b.Text);
            errorMax = double.Parse(ErrMax.Text);
            numMaxIte = int.Parse(numMaxIter.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metBiseccion(a, b, ref this.dgv_result); 
        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ErrMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numMaxIter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
