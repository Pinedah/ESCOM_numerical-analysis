namespace MetodosNumericos
{
    partial class frmSimpson1_3Doble
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            this.tf_b = new System.Windows.Forms.TextBox();
            this.tf_a = new System.Windows.Forms.TextBox();
            this.tf_n = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tf_d = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tf_c = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tf_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tf_res = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tf_b
            // 
            this.tf_b.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_b.Location = new System.Drawing.Point(52, 80);
            this.tf_b.Name = "tf_b";
            this.tf_b.Size = new System.Drawing.Size(100, 29);
            this.tf_b.TabIndex = 59;
            // 
            // tf_a
            // 
            this.tf_a.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_a.Location = new System.Drawing.Point(52, 41);
            this.tf_a.Name = "tf_a";
            this.tf_a.Size = new System.Drawing.Size(100, 29);
            this.tf_a.TabIndex = 58;
            // 
            // tf_n
            // 
            this.tf_n.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_n.Location = new System.Drawing.Point(52, 118);
            this.tf_n.Name = "tf_n";
            this.tf_n.Size = new System.Drawing.Size(100, 29);
            this.tf_n.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "ky:";
            // 
            // tf_d
            // 
            this.tf_d.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_d.Location = new System.Drawing.Point(202, 80);
            this.tf_d.Name = "tf_d";
            this.tf_d.Size = new System.Drawing.Size(100, 29);
            this.tf_d.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "d:";
            // 
            // tf_c
            // 
            this.tf_c.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_c.Location = new System.Drawing.Point(202, 41);
            this.tf_c.Name = "tf_c";
            this.tf_c.Size = new System.Drawing.Size(100, 29);
            this.tf_c.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 22);
            this.label8.TabIndex = 52;
            this.label8.Text = "c:";
            // 
            // tf_m
            // 
            this.tf_m.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_m.Location = new System.Drawing.Point(202, 118);
            this.tf_m.Name = "tf_m";
            this.tf_m.Size = new System.Drawing.Size(100, 29);
            this.tf_m.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Resultado:";
            // 
            // tf_res
            // 
            this.tf_res.Enabled = false;
            this.tf_res.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_res.Location = new System.Drawing.Point(440, 116);
            this.tf_res.Name = "tf_res";
            this.tf_res.Size = new System.Drawing.Size(123, 29);
            this.tf_res.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(21, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 22);
            label2.TabIndex = 48;
            label2.Text = "kx:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(440, 60);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 47;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(22, 82);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(25, 22);
            label5.TabIndex = 46;
            label5.Text = "b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(22, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(24, 22);
            label4.TabIndex = 45;
            label4.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "MÉTODO DE SIMPSON 1/3 DOBLE";
            // 
            // frmSimpson1_3Doble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tf_b);
            this.Controls.Add(this.tf_a);
            this.Controls.Add(this.tf_n);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tf_d);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tf_c);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tf_m);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tf_res);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.label1);
            this.Name = "frmSimpson1_3Doble";
            this.Text = "frmSimpson1_3Doble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tf_b;
        private System.Windows.Forms.TextBox tf_a;
        private System.Windows.Forms.TextBox tf_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tf_d;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tf_c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tf_m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tf_res;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
    }
}