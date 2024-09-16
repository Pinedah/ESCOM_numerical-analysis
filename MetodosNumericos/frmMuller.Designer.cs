namespace MetodosNumericos
{
    partial class frmMuller
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
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_p0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrMaxMu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxIterMu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(12, 169);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(645, 269);
            this.dgv_result.TabIndex = 21;
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(534, 72);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular.TabIndex = 20;
            this.btn_calcular.Text = "Calcular raíz";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_p1
            // 
            this.txt_p1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p1.Location = new System.Drawing.Point(299, 129);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 29);
            this.txt_p1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "P1:";
            // 
            // txt_p0
            // 
            this.txt_p0.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p0.Location = new System.Drawing.Point(138, 129);
            this.txt_p0.Name = "txt_p0";
            this.txt_p0.Size = new System.Drawing.Size(100, 29);
            this.txt_p0.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "P0:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ErrMaxMu
            // 
            this.ErrMaxMu.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMaxMu.Location = new System.Drawing.Point(346, 94);
            this.ErrMaxMu.Name = "ErrMaxMu";
            this.ErrMaxMu.Size = new System.Drawing.Size(100, 29);
            this.ErrMaxMu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Error máximo:";
            // 
            // numMaxIterMu
            // 
            this.numMaxIterMu.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxIterMu.Location = new System.Drawing.Point(346, 59);
            this.numMaxIterMu.Name = "numMaxIterMu";
            this.numMaxIterMu.Size = new System.Drawing.Size(100, 29);
            this.numMaxIterMu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número máximo de iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "MÉTODO DE MULLER";
            // 
            // txt_p2
            // 
            this.txt_p2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p2.Location = new System.Drawing.Point(460, 129);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 29);
            this.txt_p2.TabIndex = 23;
            this.txt_p2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "P2:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_result);
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
            this.Name = "frmMuller";
            this.Text = "frmMuller";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_p0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrMaxMu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numMaxIterMu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_p2;
        private System.Windows.Forms.Label label6;
    }
}