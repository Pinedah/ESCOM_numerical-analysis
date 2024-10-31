namespace MetodosNumericos
{
    partial class frmSimpson3_8
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
            this.label3 = new System.Windows.Forms.Label();
            this.tf_res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tf_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tf_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tf_k = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tf_res
            // 
            this.tf_res.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_res.Location = new System.Drawing.Point(335, 113);
            this.tf_res.Name = "tf_res";
            this.tf_res.Size = new System.Drawing.Size(123, 29);
            this.tf_res.TabIndex = 43;
            this.tf_res.TextChanged += new System.EventHandler(this.tf_res_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "k:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(335, 15);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 41;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tf_b
            // 
            this.tf_b.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_b.Location = new System.Drawing.Point(55, 79);
            this.tf_b.Name = "tf_b";
            this.tf_b.Size = new System.Drawing.Size(100, 29);
            this.tf_b.TabIndex = 40;
            this.tf_b.TextChanged += new System.EventHandler(this.tf_b_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "b:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tf_a
            // 
            this.tf_a.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_a.Location = new System.Drawing.Point(55, 40);
            this.tf_a.Name = "tf_a";
            this.tf_a.Size = new System.Drawing.Size(100, 29);
            this.tf_a.TabIndex = 38;
            this.tf_a.TextChanged += new System.EventHandler(this.tf_a_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "a:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tf_k
            // 
            this.tf_k.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_k.Location = new System.Drawing.Point(55, 117);
            this.tf_k.Name = "tf_k";
            this.tf_k.Size = new System.Drawing.Size(100, 29);
            this.tf_k.TabIndex = 36;
            this.tf_k.TextChanged += new System.EventHandler(this.tf_k_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "MÉTODO DE SIMPSON 3/8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSimpson3_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tf_res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tf_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tf_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tf_k);
            this.Controls.Add(this.label1);
            this.Name = "frmSimpson3_8";
            this.Text = "frmSimpson3_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tf_res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tf_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tf_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tf_k;
        private System.Windows.Forms.Label label1;
    }
}