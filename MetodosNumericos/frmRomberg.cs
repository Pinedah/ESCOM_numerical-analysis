﻿using System;
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
    public partial class frmRomberg : Form
    {
        public frmRomberg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            float a, b;
            int n;
            float errorMax;
            float res;

            a = float.Parse(tf_a.Text);
            b = float.Parse(tf_b.Text);
            n = int.Parse(tf_n.Text);
            errorMax = float.Parse(tf_error.Text);

            Integracion integracion = new Integracion();
            
            res = integracion.Romberg(a, b, n, errorMax, ref this.dgv_result);
            tf_res.Text=res.ToString();
        }

        private void tf_error_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tf_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tf_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tf_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tf_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
