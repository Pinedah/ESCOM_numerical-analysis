namespace MetodosNumericos
{
    partial class TecladoForms
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
            this.Guardar = new System.Windows.Forms.Button();
            this.funcion = new System.Windows.Forms.Label();
            this.txtbx_funcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(515, 180);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(129, 50);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcion
            // 
            this.funcion.AutoSize = true;
            this.funcion.Location = new System.Drawing.Point(48, 19);
            this.funcion.Name = "funcion";
            this.funcion.Size = new System.Drawing.Size(45, 13);
            this.funcion.TabIndex = 1;
            this.funcion.Text = "Función";
            // 
            // txtbx_funcion
            // 
            this.txtbx_funcion.Location = new System.Drawing.Point(51, 53);
            this.txtbx_funcion.Name = "txtbx_funcion";
            this.txtbx_funcion.Size = new System.Drawing.Size(461, 20);
            this.txtbx_funcion.TabIndex = 2;
            this.txtbx_funcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TecladoForms
            // 
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.txtbx_funcion);
            this.Controls.Add(this.funcion);
            this.Controls.Add(this.Guardar);
            this.Name = "TecladoForms";
            this.Load += new System.EventHandler(this.TecladoForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label funcion;
        private System.Windows.Forms.TextBox txtbx_funcion;
    }
}