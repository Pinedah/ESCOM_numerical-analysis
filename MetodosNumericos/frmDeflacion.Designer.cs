namespace MetodosNumericos
{
    partial class frmDeflacion
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
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_p0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrMaxMu = new System.Windows.Forms.TextBox();
            this.numMaxIterMu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gradoPol = new System.Windows.Forms.TextBox();
            this.btn_coeficientes = new System.Windows.Forms.Button();
            this.txtCoef = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.btn_grado = new System.Windows.Forms.Button();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_p2
            // 
            this.txt_p2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p2.Location = new System.Drawing.Point(389, 215);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 29);
            this.txt_p2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "P2:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(540, 211);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 33;
            this.btn_calcular.Text = "Calcular raíces";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_p1
            // 
            this.txt_p1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p1.Location = new System.Drawing.Point(228, 215);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 29);
            this.txt_p1.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "P1:";
            // 
            // txt_p0
            // 
            this.txt_p0.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p0.Location = new System.Drawing.Point(67, 215);
            this.txt_p0.Name = "txt_p0";
            this.txt_p0.Size = new System.Drawing.Size(100, 29);
            this.txt_p0.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "P0:";
            // 
            // ErrMaxMu
            // 
            this.ErrMaxMu.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMaxMu.Location = new System.Drawing.Point(331, 143);
            this.ErrMaxMu.Name = "ErrMaxMu";
            this.ErrMaxMu.Size = new System.Drawing.Size(100, 29);
            this.ErrMaxMu.TabIndex = 28;
            // 
            // numMaxIterMu
            // 
            this.numMaxIterMu.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxIterMu.Location = new System.Drawing.Point(331, 110);
            this.numMaxIterMu.Name = "numMaxIterMu";
            this.numMaxIterMu.Size = new System.Drawing.Size(100, 29);
            this.numMaxIterMu.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Número máximo de iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "DEFLACIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Error máximo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Grado del Polinomio: ";
            // 
            // gradoPol
            // 
            this.gradoPol.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradoPol.Location = new System.Drawing.Point(228, 60);
            this.gradoPol.Name = "gradoPol";
            this.gradoPol.Size = new System.Drawing.Size(64, 29);
            this.gradoPol.TabIndex = 39;
            // 
            // btn_coeficientes
            // 
            this.btn_coeficientes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_coeficientes.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coeficientes.Location = new System.Drawing.Point(549, 59);
            this.btn_coeficientes.Name = "btn_coeficientes";
            this.btn_coeficientes.Size = new System.Drawing.Size(123, 39);
            this.btn_coeficientes.TabIndex = 40;
            this.btn_coeficientes.Text = "Guardar Coeficiente";
            this.btn_coeficientes.UseVisualStyleBackColor = true;
            this.btn_coeficientes.Click += new System.EventHandler(this.btn_coeficientes_Click);
            // 
            // txtCoef
            // 
            this.txtCoef.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoef.Location = new System.Drawing.Point(493, 63);
            this.txtCoef.Name = "txtCoef";
            this.txtCoef.Size = new System.Drawing.Size(50, 29);
            this.txtCoef.TabIndex = 41;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(442, 66);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 22);
            this.lblX.TabIndex = 42;
            this.lblX.Text = "X";
            // 
            // btn_grado
            // 
            this.btn_grado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_grado.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grado.Location = new System.Drawing.Point(298, 55);
            this.btn_grado.Name = "btn_grado";
            this.btn_grado.Size = new System.Drawing.Size(123, 39);
            this.btn_grado.TabIndex = 43;
            this.btn_grado.Text = "Guardar Grado";
            this.btn_grado.UseVisualStyleBackColor = true;
            this.btn_grado.Click += new System.EventHandler(this.btn_grado_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(18, 267);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(645, 162);
            this.dgv_result.TabIndex = 44;
            // 
            // frmDeflacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_grado);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtCoef);
            this.Controls.Add(this.btn_coeficientes);
            this.Controls.Add(this.gradoPol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_p0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrMaxMu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaxIterMu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDeflacion";
            this.Text = "frmDeflacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_p0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrMaxMu;
        private System.Windows.Forms.TextBox numMaxIterMu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gradoPol;
        private System.Windows.Forms.Button btn_coeficientes;
        private System.Windows.Forms.TextBox txtCoef;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btn_grado;
        private System.Windows.Forms.DataGridView dgv_result;
    }
}