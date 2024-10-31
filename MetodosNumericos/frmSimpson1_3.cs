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
    public partial class frmSimpson1_3 : Form
    {
        public frmSimpson1_3()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);
            int k = int.Parse(tf_k.Text);

            Integracion i = new Integracion();
            i.a = a;
            i.b = b;
            i.n = k;

            float res = i.metodoSimpson1_3(a, b, k);

            tf_res.Text = res.ToString();
        }
    }
}
