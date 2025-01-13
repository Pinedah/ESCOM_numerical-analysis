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
    public partial class frmTrapecioAbierto : Form
    {
        public frmTrapecioAbierto()
        {
            InitializeComponent();
        }

        private void frmTrapecioAbierto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);

            Integracion i = new Integracion();
            i.a = a;
            i.b = b;

            float res = i.trapezoidalOpen(a, b);

            tf_res.Text = res.ToString();
        }
    }
}
