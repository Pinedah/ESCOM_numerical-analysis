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
    public partial class frmNewton_Cottes : Form
    {
        public frmNewton_Cottes()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tf_a.Text);
            float b = float.Parse(tf_b.Text);

            Integracion i = new Integracion();
            i.a = a;
            i.b = b;

            float res = i.newton_cottes(a, b);

            tf_res.Text = res.ToString();
        }
    }
}
