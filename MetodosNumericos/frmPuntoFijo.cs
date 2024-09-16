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
    public partial class frmPuntoFijo : Form
    {
        public frmPuntoFijo()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double po, errorMax;
            int numMaxIte;
            bool res;

            po = double.Parse(txt_po.Text);
            errorMax = double.Parse(ErrMax.Text);
            numMaxIte = int.Parse(numMaxIter.Text);


            MetodosSolEc metodosSolEc = new MetodosSolEc();

            metodosSolEc.errorMaximo = errorMax;
            metodosSolEc.numMaxIter = numMaxIte;

            metodosSolEc.metPFijo(po, ref this.dgv_result);
        }
    }
}
