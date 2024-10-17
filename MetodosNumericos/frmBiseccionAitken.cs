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
    public partial class frmBiseccionAitken : Form
    {
        public frmBiseccionAitken()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a, b, errorMax;
            int numMaxIte;
            bool res;

            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);
            errorMax = float.Parse(ErrMax.Text);
            numMaxIte = int.Parse(numMaxIter.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metBiseccionAitken(a, b, ref this.dgv_result);
        }
    }
}
