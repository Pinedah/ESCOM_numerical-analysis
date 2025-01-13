namespace MetodosNumericos
{
    partial class frmSEDO
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
            this.btn_grado = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.btn_coeficientes = new System.Windows.Forms.Button();
            this.gradoPol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tf_n = new System.Windows.Forms.TextBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.tf_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tf_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_grado
            // 
            this.btn_grado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_grado.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grado.Location = new System.Drawing.Point(336, 66);
            this.btn_grado.Name = "btn_grado";
            this.btn_grado.Size = new System.Drawing.Size(123, 39);
            this.btn_grado.TabIndex = 49;
            this.btn_grado.Text = "Guardar Grado";
            this.btn_grado.UseVisualStyleBackColor = true;
            this.btn_grado.Click += new System.EventHandler(this.btn_grado_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(514, 74);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 22);
            this.lblX.TabIndex = 48;
            this.lblX.Text = "C.I.";
            this.lblX.Visible = false;
            // 
            // txtCoef
            // 
            this.txtCoef.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoef.Location = new System.Drawing.Point(591, 71);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(50, 29);
            this.txtCoef.TabIndex = 47;
            this.txtCoef.Visible = false;
            // 
            // btn_coeficientes
            // 
            this.btn_coeficientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_coeficientes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coeficientes.Location = new System.Drawing.Point(647, 67);
            this.btn_coeficientes.Name = "btn_coeficientes";
            this.btn_coeficientes.Size = new System.Drawing.Size(123, 39);
            this.btn_coeficientes.TabIndex = 46;
            this.btn_coeficientes.Text = "Guardar Coeficiente";
            this.btn_coeficientes.UseVisualStyleBackColor = true;
            this.btn_coeficientes.Visible = false;
            this.btn_coeficientes.Click += new System.EventHandler(this.btn_coeficientes_Click);
            // 
            // gradoPol
            // 
            this.gradoPol.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradoPol.Location = new System.Drawing.Point(236, 71);
            this.gradoPol.Name = "gradoPol";
            this.gradoPol.Size = new System.Drawing.Size(64, 29);
            this.gradoPol.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Grado del Sistema: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "n:";
            this.label6.Visible = false;
            // 
            // tf_n
            // 
            this.tf_n.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_n.Location = new System.Drawing.Point(395, 155);
            this.tf_n.Name = "tf_n";
            this.tf_n.Size = new System.Drawing.Size(100, 29);
            this.tf_n.TabIndex = 62;
            this.tf_n.Visible = false;
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(45, 231);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(725, 234);
            this.dgv_result.TabIndex = 61;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(575, 151);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 57;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Visible = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // tf_b
            // 
            this.tf_b.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_b.Location = new System.Drawing.Point(152, 176);
            this.tf_b.Name = "tf_b";
            this.tf_b.Size = new System.Drawing.Size(100, 29);
            this.tf_b.TabIndex = 56;
            this.tf_b.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "b:";
            this.label5.Visible = false;
            // 
            // tf_a
            // 
            this.tf_a.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_a.Location = new System.Drawing.Point(152, 137);
            this.tf_a.Name = "tf_a";
            this.tf_a.Size = new System.Drawing.Size(100, 29);
            this.tf_a.TabIndex = 54;
            this.tf_a.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "a:";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "MÉTODO DE RK-4 SEDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSEDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tf_n);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tf_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tf_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_grado);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.btn_coeficientes);
            this.Controls.Add(this.gradoPol);
            this.Controls.Add(this.label8);
            this.Name = "frmSEDO";
            this.Text = "frmSEDO";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_grado;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.Button btn_coeficientes;
        private System.Windows.Forms.TextBox gradoPol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tf_n;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tf_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tf_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}