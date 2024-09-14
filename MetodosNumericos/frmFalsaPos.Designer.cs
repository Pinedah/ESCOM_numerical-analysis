namespace MetodosNumericos
{
    partial class frmFalsaPos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_calcular_fp = new System.Windows.Forms.Button();
            this.txt_b_fp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_a_fp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrMaxFP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_max_iter_fp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(80, 163);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.Size = new System.Drawing.Size(645, 269);
            this.dgv_result.TabIndex = 21;
            // 
            // btn_calcular_fp
            // 
            this.btn_calcular_fp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_calcular_fp.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular_fp.Location = new System.Drawing.Point(602, 18);
            this.btn_calcular_fp.Name = "btn_calcular_fp";
            this.btn_calcular_fp.Size = new System.Drawing.Size(123, 39);
            this.btn_calcular_fp.TabIndex = 20;
            this.btn_calcular_fp.Text = "Calcular raíz";
            this.btn_calcular_fp.UseVisualStyleBackColor = true;
            this.btn_calcular_fp.Click += new System.EventHandler(this.btn_calcular_fp_Click);
            // 
            // txt_b_fp
            // 
            this.txt_b_fp.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b_fp.Location = new System.Drawing.Point(625, 118);
            this.txt_b_fp.Name = "txt_b_fp";
            this.txt_b_fp.Size = new System.Drawing.Size(100, 29);
            this.txt_b_fp.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "b:";
            // 
            // txt_a_fp
            // 
            this.txt_a_fp.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a_fp.Location = new System.Drawing.Point(625, 79);
            this.txt_a_fp.Name = "txt_a_fp";
            this.txt_a_fp.Size = new System.Drawing.Size(100, 29);
            this.txt_a_fp.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "a:";
            // 
            // ErrMaxFP
            // 
            this.ErrMaxFP.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMaxFP.Location = new System.Drawing.Point(414, 120);
            this.ErrMaxFP.Name = "ErrMaxFP";
            this.ErrMaxFP.Size = new System.Drawing.Size(100, 29);
            this.ErrMaxFP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Error máximo:";
            // 
            // num_max_iter_fp
            // 
            this.num_max_iter_fp.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_max_iter_fp.Location = new System.Drawing.Point(414, 79);
            this.num_max_iter_fp.Name = "num_max_iter_fp";
            this.num_max_iter_fp.Size = new System.Drawing.Size(100, 29);
            this.num_max_iter_fp.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número máximo de iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "MÉTODO FALSA POSICICION";
            // 
            // metFalsaPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_calcular_fp);
            this.Controls.Add(this.txt_b_fp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_a_fp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrMaxFP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_max_iter_fp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "metFalsaPos";
            this.Text = "metFalsaPos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_calcular_fp;
        private System.Windows.Forms.TextBox txt_b_fp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a_fp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrMaxFP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_max_iter_fp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}