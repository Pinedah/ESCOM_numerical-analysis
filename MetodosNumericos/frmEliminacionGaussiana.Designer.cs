namespace MetodosNumericos
{
    partial class frmEliminacionGaussiana
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
            this.dgvMatrizIngresada = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncognitas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrizIngresada
            // 
            this.dgvMatrizIngresada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizIngresada.Location = new System.Drawing.Point(12, 70);
            this.dgvMatrizIngresada.Name = "dgvMatrizIngresada";
            this.dgvMatrizIngresada.Size = new System.Drawing.Size(412, 216);
            this.dgvMatrizIngresada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Incógnitas:";
            // 
            // txtIncognitas
            // 
            this.txtIncognitas.Location = new System.Drawing.Point(152, 44);
            this.txtIncognitas.Name = "txtIncognitas";
            this.txtIncognitas.Size = new System.Drawing.Size(100, 20);
            this.txtIncognitas.TabIndex = 2;
            this.txtIncognitas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmEliminacionGaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 437);
            this.Controls.Add(this.txtIncognitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrizIngresada);
            this.Name = "frmEliminacionGaussiana";
            this.Text = "frmEliminacionGaussiana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrizIngresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncognitas;
    }
}