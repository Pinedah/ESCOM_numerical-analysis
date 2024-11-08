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
    public partial class frmSimpson1_3Doble : Form
    {
        public frmSimpson1_3Doble()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);
            int n = int.Parse(tf_n.Text);

            float c = float.Parse(tf_c.Text);
            float d = float.Parse(tf_d.Text);
            int m = int.Parse(tf_m.Text);


            Integracion i = new Integracion();
            i.a = a;
            i.b = b;
            i.n = n;

            float res = i.metodoSimpson1_3Doble(a, b, c, d, n, m);

            tf_res.Text = res.ToString();
        }
    }
}
