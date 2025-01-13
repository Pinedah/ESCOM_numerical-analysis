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
    public partial class frmDerivacion3 : Form
    {
        public frmDerivacion3()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float x0 = float.Parse(tf_x0.Text);
            float h = float.Parse(tf_h.Text);

            Derivacion d = new Derivacion();
            d.x0 = x0;
            d.h = h;

            float res = d.Derivacion3Puntos(x0, h);

            tf_res.Text = res.ToString();
        }
    }
}
