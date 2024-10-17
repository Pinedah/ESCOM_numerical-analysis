using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class frmDeflacion : Form
    {
        public frmDeflacion()
        {
            InitializeComponent();
            
            lblX.Visible = false;
            txtCoef.Visible = false;    
            btn_coeficientes.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            numMaxIterMu.Visible = false;
            ErrMaxMu.Visible = false;
            txt_p0.Visible = false;
            txt_p1.Visible = false;
            txt_p2.Visible = false;
            btn_calcular.Visible = false;
            dgv_result.Visible = false;
        }

        int grado = 0, contador = 0;
        List<Complex> coeficientes = new List<Complex>();

        private void btn_grado_Click(object sender, EventArgs e)
        {
            grado = int.Parse(gradoPol.Text);
            lblX.Visible = true;
            txtCoef.Visible = true;
            btn_coeficientes.Visible = true;

            lblX.Text = "X^0";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Complex[] arr = coeficientes.ToArray();
            int maxIter = int.Parse(numMaxIterMu.Text);
            float errMax = float.Parse(ErrMaxMu.Text);
            Complex p0 = ParseComplex(txt_p0.Text);
            Complex p1 = ParseComplex(txt_p1.Text);
            Complex p2 = ParseComplex(txt_p2.Text);

            MetodosSolEc metodosSolEc = new MetodosSolEc();
            metodosSolEc.numMaxIter = maxIter;
            metodosSolEc.errorMaximo = errMax;
            metodosSolEc.deflacion(p0, p1, p2, arr, ref this.dgv_result);
        }

        private Complex ParseComplex(string input)
        {
            input = input.Replace(" ", "");

            string[] parts = input.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

            bool isNegativeImaginary = input.Contains("-") && input.LastIndexOf('-') > 0;

            float realPart = float.Parse(parts[0]);

            float imaginaryPart = float.Parse(parts[1].Replace("i", ""));
            if (isNegativeImaginary)
            {
                imaginaryPart = -imaginaryPart;
            }

            return new Complex(realPart, imaginaryPart);
        }

        private void btn_coeficientes_Click(object sender, EventArgs e)
        {
            coeficientes.Add(new Complex(float.Parse(txtCoef.Text), 0));
            if (contador == grado)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                numMaxIterMu.Visible = true;
                ErrMaxMu.Visible = true;
                txt_p0.Visible = true;
                txt_p1.Visible = true;
                txt_p2.Visible = true;
                btn_calcular.Visible = true;
                dgv_result.Visible = true;
            }
            else
            {
                int aux = contador;
                lblX.Text = "X^" + (aux + 1);
                txtCoef.Text = "";
                contador++;
            }
        }

    }
}
