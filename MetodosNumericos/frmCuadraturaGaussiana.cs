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
    public partial class frmCuadraturaGaussiana : Form
    {
        public frmCuadraturaGaussiana()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a, b;

            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);

            Integracion integracion = new Integracion();

            float res = integracion.cuadraturaGaussiana(a, b);
            tf_res.Text = res.ToString();
        }
    }
}
