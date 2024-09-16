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
    public partial class frmFalsaPos : Form
    {
        public frmFalsaPos()
        {
            InitializeComponent();
        }

        private void btn_calcular_fp_Click(object sender, EventArgs e)
        {
            double a, b, errorMax;
            int numMaxIte;
            bool res;

            a = double.Parse(txt_a_fp.Text);
            b = double.Parse(txt_b_fp.Text);
            errorMax = double.Parse(ErrMaxFP.Text);
            numMaxIte = int.Parse(num_max_iter_fp.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metodoFalsaPosicion(a, b, ref this.dgv_result);
        }
    }
}
