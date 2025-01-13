using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


        float[,] MatrizA;
        int NumIncognitas;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtIncognitas.Text == "")
                NumIncognitas = 0;
            else
                NumIncognitas = int.Parse(txtIncognitas.Text);
            
            dgvMatrizIngresada.Rows.Clear();
            dgvMatrizIngresada.Columns.Clear();

            for (int i = 0; i <= NumIncognitas; i++)
                dgvMatrizIngresada.Columns.Add("Columna" + i, "Columna" + i);
             for (int i = 0; i < NumIncognitas; i++)
                dgvMatrizIngresada.Rows.Add();

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            MatrizA = new float[NumIncognitas, NumIncognitas + 1];

            Console.WriteLine(NumIncognitas);


            int i, j;

            for (i = 0; i < NumIncognitas; i++)
                for (j = 0; j <= NumIncognitas; j++)
                    MatrizA[i, j] = float.Parse(dgvMatrizIngresada.Rows[i].Cells[j].Value.ToString());
            SistemasEcuaciones sisEc = new SistemasEcuaciones();

            if(radio_eliGauss.Checked)
                sisEc.ElimGaussiana(NumIncognitas, ref MatrizA, ref dgvTriangular, ref dgvResultados);
            else if(radio_pivMax.Checked)
                sisEc.PivoteoMaximoColumna(NumIncognitas, ref MatrizA, ref dgvTriangular, ref dgvResultados);
            else 
                sisEc.PivoteoEscalado(NumIncognitas, ref MatrizA, ref dgvTriangular, ref dgvResultados);




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
