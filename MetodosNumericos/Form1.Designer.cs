namespace MetodosNumericos
{
    partial class frm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raicesDeEcuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeBiseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeMullerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeLaSecanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeNewtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDePuntoFijoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDeLaFalsaPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDeSteffensenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDeBiseccionAitkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDeLaSecanteAitkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deflaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpson13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpson38ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesDeEcuacionesToolStripMenuItem,
            this.integraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raicesDeEcuacionesToolStripMenuItem
            // 
            this.raicesDeEcuacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.raicesDeEcuacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDeBiseccionToolStripMenuItem,
            this.metodoDeMullerToolStripMenuItem,
            this.metodoDeLaSecanteToolStripMenuItem,
            this.metodoDeNewtonToolStripMenuItem,
            this.métodoDePuntoFijoToolStripMenuItem,
            this.métodoDeLaFalsaPosiciónToolStripMenuItem,
            this.métodoDeSteffensenToolStripMenuItem,
            this.métodoDeBiseccionAitkenToolStripMenuItem,
            this.métodoDeLaSecanteAitkenToolStripMenuItem,
            this.deflaciónToolStripMenuItem});
            this.raicesDeEcuacionesToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raicesDeEcuacionesToolStripMenuItem.Name = "raicesDeEcuacionesToolStripMenuItem";
            this.raicesDeEcuacionesToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.raicesDeEcuacionesToolStripMenuItem.Text = "Raices de Ecuaciones";
            // 
            // metodoDeBiseccionToolStripMenuItem
            // 
            this.metodoDeBiseccionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.metodoDeBiseccionToolStripMenuItem.Name = "metodoDeBiseccionToolStripMenuItem";
            this.metodoDeBiseccionToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.metodoDeBiseccionToolStripMenuItem.Text = "Metodo de Biseccion";
            this.metodoDeBiseccionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeBiseccionToolStripMenuItem_Click);
            // 
            // metodoDeMullerToolStripMenuItem
            // 
            this.metodoDeMullerToolStripMenuItem.Name = "metodoDeMullerToolStripMenuItem";
            this.metodoDeMullerToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.metodoDeMullerToolStripMenuItem.Text = "Metodo de Muller";
            this.metodoDeMullerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeMullerToolStripMenuItem_Click);
            // 
            // metodoDeLaSecanteToolStripMenuItem
            // 
            this.metodoDeLaSecanteToolStripMenuItem.Name = "metodoDeLaSecanteToolStripMenuItem";
            this.metodoDeLaSecanteToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.metodoDeLaSecanteToolStripMenuItem.Text = "Metodo de la Secante";
            this.metodoDeLaSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoDeLaSecanteToolStripMenuItem_Click);
            // 
            // metodoDeNewtonToolStripMenuItem
            // 
            this.metodoDeNewtonToolStripMenuItem.Name = "metodoDeNewtonToolStripMenuItem";
            this.metodoDeNewtonToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.metodoDeNewtonToolStripMenuItem.Text = "Metodo de Newton";
            this.metodoDeNewtonToolStripMenuItem.Click += new System.EventHandler(this.metodoDeNewtonToolStripMenuItem_Click);
            // 
            // métodoDePuntoFijoToolStripMenuItem
            // 
            this.métodoDePuntoFijoToolStripMenuItem.Name = "métodoDePuntoFijoToolStripMenuItem";
            this.métodoDePuntoFijoToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.métodoDePuntoFijoToolStripMenuItem.Text = "Método de Punto Fijo";
            this.métodoDePuntoFijoToolStripMenuItem.Click += new System.EventHandler(this.métodoDePuntoFijoToolStripMenuItem_Click);
            // 
            // métodoDeLaFalsaPosiciónToolStripMenuItem
            // 
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Name = "métodoDeLaFalsaPosiciónToolStripMenuItem";
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Text = "Método de la Falsa posición";
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Click += new System.EventHandler(this.métodoDeLaFalsaPosiciónToolStripMenuItem_Click);
            // 
            // métodoDeSteffensenToolStripMenuItem
            // 
            this.métodoDeSteffensenToolStripMenuItem.Name = "métodoDeSteffensenToolStripMenuItem";
            this.métodoDeSteffensenToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.métodoDeSteffensenToolStripMenuItem.Text = "Método de Steffensen";
            this.métodoDeSteffensenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeSteffensenToolStripMenuItem_Click);
            // 
            // métodoDeBiseccionAitkenToolStripMenuItem
            // 
            this.métodoDeBiseccionAitkenToolStripMenuItem.Name = "métodoDeBiseccionAitkenToolStripMenuItem";
            this.métodoDeBiseccionAitkenToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.métodoDeBiseccionAitkenToolStripMenuItem.Text = "Método de Biseccion-Aitken";
            this.métodoDeBiseccionAitkenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeBiseccionAitkenToolStripMenuItem_Click);
            // 
            // métodoDeLaSecanteAitkenToolStripMenuItem
            // 
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Name = "métodoDeLaSecanteAitkenToolStripMenuItem";
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Text = "Método de la Secante-Aitken";
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeLaSecanteAitkenToolStripMenuItem_Click);
            // 
            // deflaciónToolStripMenuItem
            // 
            this.deflaciónToolStripMenuItem.Name = "deflaciónToolStripMenuItem";
            this.deflaciónToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.deflaciónToolStripMenuItem.Text = "Deflación";
            this.deflaciónToolStripMenuItem.Click += new System.EventHandler(this.deflaciónToolStripMenuItem_Click);
            // 
            // integraciónToolStripMenuItem
            // 
            this.integraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapecioCompuestoToolStripMenuItem,
            this.simpson13ToolStripMenuItem,
            this.simpson38ToolStripMenuItem});
            this.integraciónToolStripMenuItem.Name = "integraciónToolStripMenuItem";
            this.integraciónToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.integraciónToolStripMenuItem.Text = "Integración";
            // 
            // trapecioCompuestoToolStripMenuItem
            // 
            this.trapecioCompuestoToolStripMenuItem.Name = "trapecioCompuestoToolStripMenuItem";
            this.trapecioCompuestoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.trapecioCompuestoToolStripMenuItem.Text = "Trapecio Compuesto";
            this.trapecioCompuestoToolStripMenuItem.Click += new System.EventHandler(this.trapecioCompuestoToolStripMenuItem_Click);
            // 
            // simpson13ToolStripMenuItem
            // 
            this.simpson13ToolStripMenuItem.Name = "simpson13ToolStripMenuItem";
            this.simpson13ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.simpson13ToolStripMenuItem.Text = "Simpson 1/3";
            this.simpson13ToolStripMenuItem.Click += new System.EventHandler(this.simpson13ToolStripMenuItem_Click);
            // 
            // simpson38ToolStripMenuItem
            // 
            this.simpson38ToolStripMenuItem.Name = "simpson38ToolStripMenuItem";
            this.simpson38ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.simpson38ToolStripMenuItem.Text = "Simpson 3/8";
            this.simpson38ToolStripMenuItem.Click += new System.EventHandler(this.simpson38ToolStripMenuItem_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raicesDeEcuacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeBiseccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeMullerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeLaSecanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeNewtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDePuntoFijoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDeLaFalsaPosiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDeSteffensenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDeBiseccionAitkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDeLaSecanteAitkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deflaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioCompuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpson13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpson38ToolStripMenuItem;
    }
}

