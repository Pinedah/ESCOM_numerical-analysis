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
    public partial class frmCuadraturaAdaptiva : Form
    {
        public frmCuadraturaAdaptiva()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a, b;
            float errorMax;

            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);
            errorMax = float.Parse(tf_error.Text);

            Integracion integracion = new Integracion();

            float res = integracion.cuadraturaAdaptiva(a, b, errorMax);
            tf_res.Text = res.ToString();
        }
    }
}
