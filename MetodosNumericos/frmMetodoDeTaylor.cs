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
    public partial class frmMetodoDeTaylor : Form
    {
        public frmMetodoDeTaylor()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float condicion, h, error;

            condicion = float.Parse(tf_condicion.Text);
            h = float.Parse(tf_h.Text);
            error = float.Parse(tf_error.Text);

            EcuacionesDiferenciales ed = new EcuacionesDiferenciales();

            float res = ed.metodoDeTaylor(condicion, h, error);
            tf_res.Text = res.ToString();
        }
    }
}
