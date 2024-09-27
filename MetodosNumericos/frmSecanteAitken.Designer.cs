namespace MetodosNumericos
{
    partial class frmSecanteAitken
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
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_b_s = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_a_s = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrMaxMu_s = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxIterMu_s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(22, 168);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(645, 269);
            this.dgv_result.TabIndex = 45;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(544, 71);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 44;
            this.btn_calcular.Text = "Calcular raíz";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_b_s
            // 
            this.txt_b_s.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b_s.Location = new System.Drawing.Point(309, 128);
            this.txt_b_s.Name = "txt_b_s";
            this.txt_b_s.Size = new System.Drawing.Size(100, 29);
            this.txt_b_s.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "b :";
            // 
            // txt_a_s
            // 
            this.txt_a_s.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a_s.Location = new System.Drawing.Point(148, 128);
            this.txt_a_s.Name = "txt_a_s";
            this.txt_a_s.Size = new System.Drawing.Size(100, 29);
            this.txt_a_s.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "a :";
            // 
            // ErrMaxMu_s
            // 
            this.ErrMaxMu_s.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMaxMu_s.Location = new System.Drawing.Point(356, 93);
            this.ErrMaxMu_s.Name = "ErrMaxMu_s";
            this.ErrMaxMu_s.Size = new System.Drawing.Size(100, 29);
            this.ErrMaxMu_s.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Error máximo:";
            // 
            // numMaxIterMu_s
            // 
            this.numMaxIterMu_s.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxIterMu_s.Location = new System.Drawing.Point(356, 58);
            this.numMaxIterMu_s.Name = "numMaxIterMu_s";
            this.numMaxIterMu_s.Size = new System.Drawing.Size(100, 29);
            this.numMaxIterMu_s.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Número máximo de iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "MÉTODO DE SECANTE - AITKEN";
            // 
            // frmSecanteAitken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_b_s);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_a_s);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrMaxMu_s);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMaxIterMu_s);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSecanteAitken";
            this.Text = "frmSecanteAitken";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_b_s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrMaxMu_s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numMaxIterMu_s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}