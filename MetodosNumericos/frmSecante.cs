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
    public partial class frmSecante : Form
    {
        public frmSecante()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a, b, errorMax;
            int numMaxIte;
            bool res;

            a = double.Parse(txt_a_s.Text);
            b = double.Parse(txt_b_s.Text);
            errorMax = double.Parse(ErrMaxMu_s.Text);
            numMaxIte = int.Parse(numMaxIterMu_s.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metSecante(a, b, ref this.dgv_result);
        }
    }
}
