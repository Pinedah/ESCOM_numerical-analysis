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
    public partial class frmSteffensen : Form
    {
        public frmSteffensen()
        {
            InitializeComponent();
        }

        private void frmSteffensen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float po, errorMax;
            int numMaxIte;

            po = float.Parse(txt_po.Text);
            errorMax = float.Parse(ErrMax.Text);
            numMaxIte = int.Parse(numMaxIter.Text);


            MetodosSolEc metodosSolEc = new MetodosSolEc();

            metodosSolEc.errorMaximo = errorMax;
            metodosSolEc.numMaxIter = numMaxIte;

            metodosSolEc.metSteffensen(po, ref this.dgv_result);
        }
    }
}
