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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_eliGauss = new System.Windows.Forms.RadioButton();
            this.radio_pivMax = new System.Windows.Forms.RadioButton();
            this.radio_pivEsc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriangular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 302);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(240, 192);
            this.dgvResultados.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // radio_eliGauss
            // 
            this.radio_eliGauss.AutoSize = true;
            this.radio_eliGauss.Location = new System.Drawing.Point(6, 29);
            this.radio_eliGauss.Name = "radio_eliGauss";
            this.radio_eliGauss.Size = new System.Drawing.Size(131, 17);
            this.radio_eliGauss.TabIndex = 7;
            this.radio_eliGauss.TabStop = true;
            this.radio_eliGauss.Text = "Eliminación Gaussiana";
            this.radio_eliGauss.UseVisualStyleBackColor = true;
            // 
            // radio_pivMax
            // 
            this.radio_pivMax.AutoSize = true;
            this.radio_pivMax.Location = new System.Drawing.Point(6, 52);
            this.radio_pivMax.Name = "radio_pivMax";
            this.radio_pivMax.Size = new System.Drawing.Size(159, 17);
            this.radio_pivMax.TabIndex = 8;
            this.radio_pivMax.TabStop = true;
            this.radio_pivMax.Text = "Pivoteo Máximo de Columna";
            this.radio_pivMax.UseVisualStyleBackColor = true;
            // 
            // radio_pivEsc
            // 
            this.radio_pivEsc.AutoSize = true;
            this.radio_pivEsc.Location = new System.Drawing.Point(6, 75);
            this.radio_pivEsc.Name = "radio_pivEsc";
            this.radio_pivEsc.Size = new System.Drawing.Size(108, 17);
            this.radio_pivEsc.TabIndex = 9;
            this.radio_pivEsc.TabStop = true;
            this.radio_pivEsc.Text = "Pivoteo Escalado";
            this.radio_pivEsc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_pivMax);
            this.groupBox1.Controls.Add(this.radio_pivEsc);
            this.groupBox1.Controls.Add(this.radio_eliGauss);
            this.groupBox1.Location = new System.Drawing.Point(430, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona el método";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmEliminacionGaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.dgvTriangular);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtIncognitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrizIngresada);
            this.Name = "frmEliminacionGaussiana";
            this.Text = "frmEliminacionGaussiana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizIngresada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriangular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrizIngresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncognitas;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.DataGridView dgvTriangular;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_eliGauss;
        private System.Windows.Forms.RadioButton radio_pivMax;
        private System.Windows.Forms.RadioButton radio_pivEsc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}