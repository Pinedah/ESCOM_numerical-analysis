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
    public partial class TecladoForms : Form
    {
        public TecladoForms()
        {
            InitializeComponent();
        }

        private void TecladoForms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string funcion;
            
            funcion=txtbx_funcion.Text;

            MetodosSolEc metodos = new MetodosSolEc();
            res = metodos.metodoFalsaPosicion(a, b, ref this.dgv_result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
