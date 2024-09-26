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
    public partial class frmBiseccion_Aitken : Form
    {
        public frmBiseccion_Aitken()
        {
            InitializeComponent();
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
            res = metodos.metBiseccionAitken(a, b, ref this.dgv_result);
        }
    }
}
