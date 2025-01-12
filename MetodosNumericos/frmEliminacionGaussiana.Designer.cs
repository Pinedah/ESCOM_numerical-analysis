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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.dgvTriangular = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriangular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrizIngresada
            // 
            this.dgvMatrizIngresada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizIngresada.Location = new System.Drawing.Point(12, 68);
            this.dgvMatrizIngresada.Name = "dgvMatrizIngresada";
            this.dgvMatrizIngresada.Size = new System.Drawing.Size(412, 216);
            this.dgvMatrizIngresada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Incógnitas:";
            // 
            // txtIncognitas
            // 
            this.txtIncognitas.Location = new System.Drawing.Point(152, 42);
            this.txtIncognitas.Name = "txtIncognitas";
            this.txtIncognitas.Size = new System.Drawing.Size(100, 20);
            this.txtIncognitas.TabIndex = 2;
            this.txtIncognitas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(430, 162);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(116, 45);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Aplicar Eliminación Gaussiana";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // dgvTriangular
            // 
            this.dgvTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriangular.Location = new System.Drawing.Point(552, 68);
            this.dgvTriangular.Name = "dgvTriangular";
            this.dgvTriangular.Size = new System.Drawing.Size(371, 216);
            this.dgvTriangular.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona el método";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(455, 347);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Eliminación Gaussiana";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(455, 370);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pivoteo Máximo de Columna";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(455, 393);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(108, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pivoteo Escalado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmEliminacionGaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvTriangular);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtIncognitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrizIngresada);
            this.Name = "frmEliminacionGaussiana";
            this.Text = "frmEliminacionGaussiana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriangular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrizIngresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncognitas;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.DataGridView dgvTriangular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}