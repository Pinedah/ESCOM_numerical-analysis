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
    public partial class frmMetodoDeHeun : Form
    {
        public frmMetodoDeHeun()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float condicion, a, b, n;
            float res;
            condicion = float.Parse(tf_condicion.Text);
            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);
            n = int.Parse(tf_n.Text);

            EcuacionesDiferenciales ecDif = new EcuacionesDiferenciales();

            res = ecDif.metodoDeHeun(condicion, a, b, n, ref this.dgv_result);
            tf_res.Text = res.ToString();
        }
    }
}
