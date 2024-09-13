﻿namespace MetodosNumericos
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesDeEcuacionesToolStripMenuItem});
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
            this.métodoDePuntoFijoToolStripMenuItem});
            this.raicesDeEcuacionesToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raicesDeEcuacionesToolStripMenuItem.Name = "raicesDeEcuacionesToolStripMenuItem";
            this.raicesDeEcuacionesToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.raicesDeEcuacionesToolStripMenuItem.Text = "Raices de Ecuaciones";
            // 
            // metodoDeBiseccionToolStripMenuItem
            // 
            this.metodoDeBiseccionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.metodoDeBiseccionToolStripMenuItem.Name = "metodoDeBiseccionToolStripMenuItem";
            this.metodoDeBiseccionToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.metodoDeBiseccionToolStripMenuItem.Text = "Metodo de Biseccion";
            this.metodoDeBiseccionToolStripMenuItem.Click += new System.EventHandler(this.metodoDeBiseccionToolStripMenuItem_Click);
            // 
            // metodoDeMullerToolStripMenuItem
            // 
            this.metodoDeMullerToolStripMenuItem.Name = "metodoDeMullerToolStripMenuItem";
            this.metodoDeMullerToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.metodoDeMullerToolStripMenuItem.Text = "Metodo de Muller";
            this.metodoDeMullerToolStripMenuItem.Click += new System.EventHandler(this.metodoDeMullerToolStripMenuItem_Click);
            // 
            // metodoDeLaSecanteToolStripMenuItem
            // 
            this.metodoDeLaSecanteToolStripMenuItem.Name = "metodoDeLaSecanteToolStripMenuItem";
            this.metodoDeLaSecanteToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.metodoDeLaSecanteToolStripMenuItem.Text = "Metodo de la Secante";
            this.metodoDeLaSecanteToolStripMenuItem.Click += new System.EventHandler(this.metodoDeLaSecanteToolStripMenuItem_Click);
            // 
            // metodoDeNewtonToolStripMenuItem
            // 
            this.metodoDeNewtonToolStripMenuItem.Name = "metodoDeNewtonToolStripMenuItem";
            this.metodoDeNewtonToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.metodoDeNewtonToolStripMenuItem.Text = "Metodo de Newton";
            this.metodoDeNewtonToolStripMenuItem.Click += new System.EventHandler(this.metodoDeNewtonToolStripMenuItem_Click);
            // 
            // métodoDePuntoFijoToolStripMenuItem
            // 
            this.métodoDePuntoFijoToolStripMenuItem.Name = "métodoDePuntoFijoToolStripMenuItem";
            this.métodoDePuntoFijoToolStripMenuItem.Size = new System.Drawing.Size(283, 28);
            this.métodoDePuntoFijoToolStripMenuItem.Text = "Método de Punto Fijo";
            this.métodoDePuntoFijoToolStripMenuItem.Click += new System.EventHandler(this.métodoDePuntoFijoToolStripMenuItem_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm";
            this.Text = "Menú Principal";
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
    }
}

