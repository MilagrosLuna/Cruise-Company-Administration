
namespace FrmParcial
{
    partial class FrmVistaPasajeros
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
            this.verPasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeRegionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeExtraRegionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPasajerosToolStripMenuItem,
            this.buscarPorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verPasajerosToolStripMenuItem
            // 
            this.verPasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionCompletaToolStripMenuItem});
            this.verPasajerosToolStripMenuItem.Name = "verPasajerosToolStripMenuItem";
            this.verPasajerosToolStripMenuItem.Size = new System.Drawing.Size(184, 41);
            this.verPasajerosToolStripMenuItem.Text = "ver pasajeros";
            // 
            // informacionCompletaToolStripMenuItem
            // 
            this.informacionCompletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajeRegionalToolStripMenuItem,
            this.viajeExtraRegionalToolStripMenuItem});
            this.informacionCompletaToolStripMenuItem.Name = "informacionCompletaToolStripMenuItem";
            this.informacionCompletaToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.informacionCompletaToolStripMenuItem.Text = "informacion completa";
            // 
            // viajeRegionalToolStripMenuItem
            // 
            this.viajeRegionalToolStripMenuItem.Name = "viajeRegionalToolStripMenuItem";
            this.viajeRegionalToolStripMenuItem.Size = new System.Drawing.Size(322, 42);
            this.viajeRegionalToolStripMenuItem.Text = "Viaje Regional";
            this.viajeRegionalToolStripMenuItem.Click += new System.EventHandler(this.viajeRegionalToolStripMenuItem_Click);
            // 
            // viajeExtraRegionalToolStripMenuItem
            // 
            this.viajeExtraRegionalToolStripMenuItem.Name = "viajeExtraRegionalToolStripMenuItem";
            this.viajeExtraRegionalToolStripMenuItem.Size = new System.Drawing.Size(322, 42);
            this.viajeExtraRegionalToolStripMenuItem.Text = "Viaje ExtraRegional";
            this.viajeExtraRegionalToolStripMenuItem.Click += new System.EventHandler(this.viajeExtraRegionalToolStripMenuItem_Click);
            // 
            // buscarPorToolStripMenuItem
            // 
            this.buscarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.pasaporteToolStripMenuItem,
            this.edadToolStripMenuItem,
            this.apellidoToolStripMenuItem});
            this.buscarPorToolStripMenuItem.Name = "buscarPorToolStripMenuItem";
            this.buscarPorToolStripMenuItem.Size = new System.Drawing.Size(154, 41);
            this.buscarPorToolStripMenuItem.Text = "buscar por";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(211, 42);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // pasaporteToolStripMenuItem
            // 
            this.pasaporteToolStripMenuItem.Name = "pasaporteToolStripMenuItem";
            this.pasaporteToolStripMenuItem.Size = new System.Drawing.Size(211, 42);
            this.pasaporteToolStripMenuItem.Text = "Pasaporte";
            this.pasaporteToolStripMenuItem.Click += new System.EventHandler(this.pasaporteToolStripMenuItem_Click);
            // 
            // edadToolStripMenuItem
            // 
            this.edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            this.edadToolStripMenuItem.Size = new System.Drawing.Size(211, 42);
            this.edadToolStripMenuItem.Text = "Edad";
            this.edadToolStripMenuItem.Click += new System.EventHandler(this.edadToolStripMenuItem_Click);
            // 
            // apellidoToolStripMenuItem
            // 
            this.apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            this.apellidoToolStripMenuItem.Size = new System.Drawing.Size(211, 42);
            this.apellidoToolStripMenuItem.Text = "Apellido";
            this.apellidoToolStripMenuItem.Click += new System.EventHandler(this.apellidoToolStripMenuItem_Click);
            // 
            // FrmVistaPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(928, 558);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(944, 597);
            this.Name = "FrmVistaPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver pasajeros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verPasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajeRegionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajeExtraRegionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoToolStripMenuItem;
    }
}