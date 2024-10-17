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
    public partial class frmSecanteAitken : Form
    {
        public frmSecanteAitken()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a, b, errorMax;
            int numMaxIte;
            bool res;

            a = float.Parse(txt_a_s.Text);
            b = float.Parse(txt_b_s.Text);
            errorMax = float.Parse(ErrMaxMu_s.Text);
            numMaxIte = int.Parse(numMaxIterMu_s.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metSecanteAitken(a, b, ref this.dgv_result);
        }
    }
}
