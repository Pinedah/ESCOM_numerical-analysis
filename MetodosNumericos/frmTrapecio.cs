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
    public partial class frmTrapecio : Form
    {
        public frmTrapecio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmTrapecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);
            int n = int.Parse(tf_n.Text);

            Integracion i = new Integracion();
            i.a = a;
            i.b = b;
            i.n = n;

            float res = i.metodoTrapecio(a, b, n);

            tf_res.Text = res.ToString();

        }
    }
}
