﻿using System;
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
    public partial class frmMuller : Form
    {
        public frmMuller()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Complex P0, P1,P2;
            float errorMax;
            int numMaxIte;
            bool res;

            P0 = ParseComplex(txt_p0.Text);
            P1 = ParseComplex(txt_p1.Text);
            P2 = ParseComplex(txt_p2.Text);
            errorMax = float.Parse(ErrMaxMu.Text);
            numMaxIte = int.Parse(numMaxIterMu.Text);

            MetodosSolEc metodos = new MetodosSolEc();
            metodos.numMaxIter = numMaxIte;
            metodos.errorMaximo = errorMax;
            res = metodos.metMuller2(P0,P1,P2, ref this.dgv_result);
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
    }
}
