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
            this.multiplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpson13ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonAbiertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonCottesN2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeRombergToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadraturaAdaptivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadraturaGaussianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesDiferencialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeEulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDeTaylorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesDeEcuacionesToolStripMenuItem,
            this.dToolStripMenuItem,
            this.integraciónToolStripMenuItem,
            this.ecuacionesDiferencialesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // raicesDeEcuacionesToolStripMenuItem
            // 
            this.raicesDeEcuacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.raicesDeEcuacionesToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold);
            this.raicesDeEcuacionesToolStripMenuItem.Name = "raicesDeEcuacionesToolStripMenuItem";
            this.raicesDeEcuacionesToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.raicesDeEcuacionesToolStripMenuItem.Text = "Raices de Ecuaciones";
            // 
            // metodoDeBiseccionToolStripMenuItem
            // 
            this.metodoDeBiseccionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.metodoDeBiseccionToolStripMenuItem.Name = "metodoDeBiseccionToolStripMenuItem";
            this.metodoDeBiseccionToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.metodoDeBiseccionToolStripMenuItem.Text = "Metodo de Biseccion";
            this.metodoDeBiseccionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeBiseccionToolStripMenuItem_Click);
            // 
            // metodoDeMullerToolStripMenuItem
            // 
            this.metodoDeMullerToolStripMenuItem.Name = "metodoDeMullerToolStripMenuItem";
            this.metodoDeMullerToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.metodoDeMullerToolStripMenuItem.Text = "Metodo de Muller";
            this.metodoDeMullerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeMullerToolStripMenuItem_Click);
            // 
            // metodoDeLaSecanteToolStripMenuItem
            // 
            this.metodoDeLaSecanteToolStripMenuItem.Name = "metodoDeLaSecanteToolStripMenuItem";
            this.metodoDeLaSecanteToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.metodoDeLaSecanteToolStripMenuItem.Text = "Metodo de la Secante";
            this.metodoDeLaSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoDeLaSecanteToolStripMenuItem_Click);
            // 
            // metodoDeNewtonToolStripMenuItem
            // 
            this.metodoDeNewtonToolStripMenuItem.Name = "metodoDeNewtonToolStripMenuItem";
            this.metodoDeNewtonToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.metodoDeNewtonToolStripMenuItem.Text = "Metodo de Newton";
            this.metodoDeNewtonToolStripMenuItem.Click += new System.EventHandler(this.metodoDeNewtonToolStripMenuItem_Click);
            // 
            // métodoDePuntoFijoToolStripMenuItem
            // 
            this.métodoDePuntoFijoToolStripMenuItem.Name = "métodoDePuntoFijoToolStripMenuItem";
            this.métodoDePuntoFijoToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.métodoDePuntoFijoToolStripMenuItem.Text = "Método de Punto Fijo";
            this.métodoDePuntoFijoToolStripMenuItem.Click += new System.EventHandler(this.métodoDePuntoFijoToolStripMenuItem_Click);
            // 
            // métodoDeLaFalsaPosiciónToolStripMenuItem
            // 
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Name = "métodoDeLaFalsaPosiciónToolStripMenuItem";
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Text = "Método de la Falsa posición";
            this.métodoDeLaFalsaPosiciónToolStripMenuItem.Click += new System.EventHandler(this.métodoDeLaFalsaPosiciónToolStripMenuItem_Click);
            // 
            // métodoDeSteffensenToolStripMenuItem
            // 
            this.métodoDeSteffensenToolStripMenuItem.Name = "métodoDeSteffensenToolStripMenuItem";
            this.métodoDeSteffensenToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.métodoDeSteffensenToolStripMenuItem.Text = "Método de Steffensen";
            this.métodoDeSteffensenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeSteffensenToolStripMenuItem_Click);
            // 
            // métodoDeBiseccionAitkenToolStripMenuItem
            // 
            this.métodoDeBiseccionAitkenToolStripMenuItem.Name = "métodoDeBiseccionAitkenToolStripMenuItem";
            this.métodoDeBiseccionAitkenToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.métodoDeBiseccionAitkenToolStripMenuItem.Text = "Método de Biseccion-Aitken";
            this.métodoDeBiseccionAitkenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeBiseccionAitkenToolStripMenuItem_Click);
            // 
            // métodoDeLaSecanteAitkenToolStripMenuItem
            // 
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Name = "métodoDeLaSecanteAitkenToolStripMenuItem";
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Text = "Método de la Secante-Aitken";
            this.métodoDeLaSecanteAitkenToolStripMenuItem.Click += new System.EventHandler(this.métodoDeLaSecanteAitkenToolStripMenuItem_Click);
            // 
            // deflaciónToolStripMenuItem
            // 
            this.deflaciónToolStripMenuItem.Name = "deflaciónToolStripMenuItem";
            this.deflaciónToolStripMenuItem.Size = new System.Drawing.Size(340, 26);
            this.deflaciónToolStripMenuItem.Text = "Deflación";
            this.deflaciónToolStripMenuItem.Click += new System.EventHandler(this.deflaciónToolStripMenuItem_Click);
            // 
            // integraciónToolStripMenuItem
            // 
            this.integraciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.integraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapecioCompuestoToolStripMenuItem,
            this.simpson13ToolStripMenuItem,
            this.simpson38ToolStripMenuItem,
            this.multiplesToolStripMenuItem,
            this.newtonAbiertasToolStripMenuItem,
            this.metodoDeRombergToolStripMenuItem,
            this.cuadraturaAdaptivaToolStripMenuItem,
            this.cuadraturaGaussianaToolStripMenuItem});
            this.integraciónToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integraciónToolStripMenuItem.Name = "integraciónToolStripMenuItem";
            this.integraciónToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.integraciónToolStripMenuItem.Text = "Integración";
            this.integraciónToolStripMenuItem.Click += new System.EventHandler(this.integraciónToolStripMenuItem_Click);
            // 
            // trapecioCompuestoToolStripMenuItem
            // 
            this.trapecioCompuestoToolStripMenuItem.Name = "trapecioCompuestoToolStripMenuItem";
            this.trapecioCompuestoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.trapecioCompuestoToolStripMenuItem.Text = "Trapecio Compuesto";
            this.trapecioCompuestoToolStripMenuItem.Click += new System.EventHandler(this.trapecioCompuestoToolStripMenuItem_Click);
            // 
            // simpson13ToolStripMenuItem
            // 
            this.simpson13ToolStripMenuItem.Name = "simpson13ToolStripMenuItem";
            this.simpson13ToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.simpson13ToolStripMenuItem.Text = "Simpson 1/3";
            this.simpson13ToolStripMenuItem.Click += new System.EventHandler(this.simpson13ToolStripMenuItem_Click);
            // 
            // simpson38ToolStripMenuItem
            // 
            this.simpson38ToolStripMenuItem.Name = "simpson38ToolStripMenuItem";
            this.simpson38ToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.simpson38ToolStripMenuItem.Text = "Simpson 3/8";
            this.simpson38ToolStripMenuItem.Click += new System.EventHandler(this.simpson38ToolStripMenuItem_Click);
            // 
            // multiplesToolStripMenuItem
            // 
            this.multiplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapecioToolStripMenuItem,
            this.simpson13ToolStripMenuItem1});
            this.multiplesToolStripMenuItem.Name = "multiplesToolStripMenuItem";
            this.multiplesToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.multiplesToolStripMenuItem.Text = "Multiples";
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.trapecioToolStripMenuItem_Click);
            // 
            // simpson13ToolStripMenuItem1
            // 
            this.simpson13ToolStripMenuItem1.Name = "simpson13ToolStripMenuItem1";
            this.simpson13ToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.simpson13ToolStripMenuItem1.Text = "Simpson 1/3";
            this.simpson13ToolStripMenuItem1.Click += new System.EventHandler(this.simpson13ToolStripMenuItem1_Click);
            // 
            // newtonAbiertasToolStripMenuItem
            // 
            this.newtonAbiertasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonCottesN2ToolStripMenuItem});
            this.newtonAbiertasToolStripMenuItem.Name = "newtonAbiertasToolStripMenuItem";
            this.newtonAbiertasToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.newtonAbiertasToolStripMenuItem.Text = "Newton Abiertas";
            // 
            // newtonCottesN2ToolStripMenuItem
            // 
            this.newtonCottesN2ToolStripMenuItem.Name = "newtonCottesN2ToolStripMenuItem";
            this.newtonCottesN2ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.newtonCottesN2ToolStripMenuItem.Text = "Newton-Cottes n=2";
            this.newtonCottesN2ToolStripMenuItem.Click += new System.EventHandler(this.newtonCottesN2ToolStripMenuItem_Click);
            // 
            // metodoDeRombergToolStripMenuItem
            // 
            this.metodoDeRombergToolStripMenuItem.Name = "metodoDeRombergToolStripMenuItem";
            this.metodoDeRombergToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.metodoDeRombergToolStripMenuItem.Text = "Metodo de Romberg";
            this.metodoDeRombergToolStripMenuItem.Click += new System.EventHandler(this.metodoDeRombergToolStripMenuItem_Click);
            // 
            // cuadraturaAdaptivaToolStripMenuItem
            // 
            this.cuadraturaAdaptivaToolStripMenuItem.Name = "cuadraturaAdaptivaToolStripMenuItem";
            this.cuadraturaAdaptivaToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.cuadraturaAdaptivaToolStripMenuItem.Text = "Cuadratura Adaptiva";
            this.cuadraturaAdaptivaToolStripMenuItem.Click += new System.EventHandler(this.cuadraturaAdaptivaToolStripMenuItem_Click);
            // 
            // cuadraturaGaussianaToolStripMenuItem
            // 
            this.cuadraturaGaussianaToolStripMenuItem.Name = "cuadraturaGaussianaToolStripMenuItem";
            this.cuadraturaGaussianaToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.cuadraturaGaussianaToolStripMenuItem.Text = "Cuadratura Gaussiana";
            this.cuadraturaGaussianaToolStripMenuItem.Click += new System.EventHandler(this.cuadraturaGaussianaToolStripMenuItem_Click);
            // 
            // ecuacionesDiferencialesToolStripMenuItem
            // 
            this.ecuacionesDiferencialesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ecuacionesDiferencialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metodoDeEulerToolStripMenuItem,
            this.metodoDeTaylorToolStripMenuItem});
            this.ecuacionesDiferencialesToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecuacionesDiferencialesToolStripMenuItem.Name = "ecuacionesDiferencialesToolStripMenuItem";
            this.ecuacionesDiferencialesToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.ecuacionesDiferencialesToolStripMenuItem.Text = "Ecuaciones Diferenciales";
            // 
            // metodoDeEulerToolStripMenuItem
            // 
            this.metodoDeEulerToolStripMenuItem.Name = "metodoDeEulerToolStripMenuItem";
            this.metodoDeEulerToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.metodoDeEulerToolStripMenuItem.Text = "Metodo de Euler";
            this.metodoDeEulerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeEulerToolStripMenuItem_Click);
            // 
            // metodoDeTaylorToolStripMenuItem
            // 
            this.metodoDeTaylorToolStripMenuItem.Name = "metodoDeTaylorToolStripMenuItem";
            this.metodoDeTaylorToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.metodoDeTaylorToolStripMenuItem.Text = "Metodo de Taylor";
            this.metodoDeTaylorToolStripMenuItem.Click += new System.EventHandler(this.metodoDeTaylorToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.dToolStripMenuItem.Text = "Derivación";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(735, 329);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
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
        private System.Windows.Forms.ToolStripMenuItem multiplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpson13ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newtonAbiertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonCottesN2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeRombergToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadraturaAdaptivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadraturaGaussianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecuacionesDiferencialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeEulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDeTaylorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
    }
}

