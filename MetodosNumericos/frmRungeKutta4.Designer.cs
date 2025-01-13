namespace MetodosNumericos
{
    partial class frmRungeKutta4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.tf_n = new System.Windows.Forms.TextBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tf_res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tf_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tf_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tf_condicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "n:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tf_n
            // 
            this.tf_n.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_n.Location = new System.Drawing.Point(185, 94);
            this.tf_n.Name = "tf_n";
            this.tf_n.Size = new System.Drawing.Size(100, 29);
            this.tf_n.TabIndex = 62;
            this.tf_n.TextChanged += new System.EventHandler(this.tf_n_TextChanged);
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(30, 153);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(665, 251);
            this.dgv_result.TabIndex = 61;
            this.dgv_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_result_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tf_res
            // 
            this.tf_res.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_res.Location = new System.Drawing.Point(572, 100);
            this.tf_res.Name = "tf_res";
            this.tf_res.Size = new System.Drawing.Size(123, 29);
            this.tf_res.TabIndex = 59;
            this.tf_res.TextChanged += new System.EventHandler(this.tf_res_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Condicion Inicial:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(572, 42);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 57;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tf_b
            // 
            this.tf_b.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_b.Location = new System.Drawing.Point(355, 91);
            this.tf_b.Name = "tf_b";
            this.tf_b.Size = new System.Drawing.Size(100, 29);
            this.tf_b.TabIndex = 56;
            this.tf_b.TextChanged += new System.EventHandler(this.tf_b_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "b:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tf_a
            // 
            this.tf_a.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_a.Location = new System.Drawing.Point(355, 52);
            this.tf_a.Name = "tf_a";
            this.tf_a.Size = new System.Drawing.Size(100, 29);
            this.tf_a.TabIndex = 54;
            this.tf_a.TextChanged += new System.EventHandler(this.tf_a_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "a:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tf_condicion
            // 
            this.tf_condicion.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_condicion.Location = new System.Drawing.Point(185, 55);
            this.tf_condicion.Name = "tf_condicion";
            this.tf_condicion.Size = new System.Drawing.Size(100, 29);
            this.tf_condicion.TabIndex = 52;
            this.tf_condicion.TextChanged += new System.EventHandler(this.tf_condicion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "MÉTODO DE RUNGE-KUTTA 4";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRungeKutta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tf_n);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tf_res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tf_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tf_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tf_condicion);
            this.Controls.Add(this.label1);
            this.Name = "frmRungeKutta4";
            this.Text = "frmRungeKutta4";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tf_n;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tf_res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tf_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tf_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tf_condicion;
        private System.Windows.Forms.Label label1;
    }
}