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
    public partial class frmEliminacionGaussiana : Form
    {
        public frmEliminacionGaussiana()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int incognitas;

            if (txtIncognitas.Text == "")
                incognitas = 0;
            else
                incognitas = int.Parse(txtIncognitas.Text);
            
            dgvMatrizIngresada.Rows.Clear();
            dgvMatrizIngresada.Columns.Clear();

            for (int i = 0; i <= incognitas; i++)
                dgvMatrizIngresada.Columns.Add("Columna" + i, "Columna" + i);
             for (int i = 0; i < incognitas; i++)
                dgvMatrizIngresada.Rows.Add();

        }
    }
}
