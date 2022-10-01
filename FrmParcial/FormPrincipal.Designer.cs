
namespace FrmParcial
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_viajeDisponible = new System.Windows.Forms.GroupBox();
            this.button_ViajesDisponibles = new System.Windows.Forms.Button();
            this.groupBox_ventaPasaje = new System.Windows.Forms.GroupBox();
            this.button_ventaPasaje = new System.Windows.Forms.Button();
            this.groupBox_estadisticas = new System.Windows.Forms.GroupBox();
            this.button_estadisticas = new System.Windows.Forms.Button();
            this.groupBox_CrearViajes = new System.Windows.Forms.GroupBox();
            this.button_crearViaje = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_listasPasajeros = new System.Windows.Forms.GroupBox();
            this.button_verPasajeros = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_viajeDisponible.SuspendLayout();
            this.groupBox_ventaPasaje.SuspendLayout();
            this.groupBox_estadisticas.SuspendLayout();
            this.groupBox_CrearViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_listasPasajeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.84419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.15581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 701F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 599);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(974, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 29);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(130, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox_viajeDisponible, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_ventaPasaje, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_estadisticas, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_CrearViajes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox_listasPasajeros, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 599);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox_viajeDisponible
            // 
            this.groupBox_viajeDisponible.Controls.Add(this.button_ViajesDisponibles);
            this.groupBox_viajeDisponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_viajeDisponible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_viajeDisponible.Location = new System.Drawing.Point(3, 3);
            this.groupBox_viajeDisponible.Name = "groupBox_viajeDisponible";
            this.groupBox_viajeDisponible.Size = new System.Drawing.Size(349, 193);
            this.groupBox_viajeDisponible.TabIndex = 0;
            this.groupBox_viajeDisponible.TabStop = false;
            this.groupBox_viajeDisponible.Text = "Viajes Disponibles";
            // 
            // button_ViajesDisponibles
            // 
            this.button_ViajesDisponibles.Location = new System.Drawing.Point(81, 144);
            this.button_ViajesDisponibles.Name = "button_ViajesDisponibles";
            this.button_ViajesDisponibles.Size = new System.Drawing.Size(126, 38);
            this.button_ViajesDisponibles.TabIndex = 0;
            this.button_ViajesDisponibles.Text = "ver viajes";
            this.button_ViajesDisponibles.UseVisualStyleBackColor = true;
            this.button_ViajesDisponibles.Click += new System.EventHandler(this.button_ViajesDisponibles_Click);
            // 
            // groupBox_ventaPasaje
            // 
            this.groupBox_ventaPasaje.Controls.Add(this.button_ventaPasaje);
            this.groupBox_ventaPasaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ventaPasaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_ventaPasaje.Location = new System.Drawing.Point(713, 401);
            this.groupBox_ventaPasaje.Name = "groupBox_ventaPasaje";
            this.groupBox_ventaPasaje.Size = new System.Drawing.Size(351, 195);
            this.groupBox_ventaPasaje.TabIndex = 1;
            this.groupBox_ventaPasaje.TabStop = false;
            this.groupBox_ventaPasaje.Text = "Venta Pasaje";
            // 
            // button_ventaPasaje
            // 
            this.button_ventaPasaje.Location = new System.Drawing.Point(126, 149);
            this.button_ventaPasaje.Name = "button_ventaPasaje";
            this.button_ventaPasaje.Size = new System.Drawing.Size(120, 36);
            this.button_ventaPasaje.TabIndex = 0;
            this.button_ventaPasaje.Text = "Vender Pasaje";
            this.button_ventaPasaje.UseVisualStyleBackColor = true;
            this.button_ventaPasaje.Click += new System.EventHandler(this.button_ventaPasaje_Click);
            // 
            // groupBox_estadisticas
            // 
            this.groupBox_estadisticas.Controls.Add(this.button_estadisticas);
            this.groupBox_estadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_estadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_estadisticas.Location = new System.Drawing.Point(3, 401);
            this.groupBox_estadisticas.Name = "groupBox_estadisticas";
            this.groupBox_estadisticas.Size = new System.Drawing.Size(349, 195);
            this.groupBox_estadisticas.TabIndex = 2;
            this.groupBox_estadisticas.TabStop = false;
            this.groupBox_estadisticas.Text = "Estadisticas Historicas";
            // 
            // button_estadisticas
            // 
            this.button_estadisticas.Location = new System.Drawing.Point(81, 153);
            this.button_estadisticas.Name = "button_estadisticas";
            this.button_estadisticas.Size = new System.Drawing.Size(126, 36);
            this.button_estadisticas.TabIndex = 0;
            this.button_estadisticas.Text = "Ver Estadisticas";
            this.button_estadisticas.UseVisualStyleBackColor = true;
            this.button_estadisticas.Click += new System.EventHandler(this.button_estadisticas_Click);
            // 
            // groupBox_CrearViajes
            // 
            this.groupBox_CrearViajes.Controls.Add(this.button_crearViaje);
            this.groupBox_CrearViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_CrearViajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_CrearViajes.Location = new System.Drawing.Point(358, 3);
            this.groupBox_CrearViajes.Name = "groupBox_CrearViajes";
            this.groupBox_CrearViajes.Size = new System.Drawing.Size(349, 193);
            this.groupBox_CrearViajes.TabIndex = 3;
            this.groupBox_CrearViajes.TabStop = false;
            this.groupBox_CrearViajes.Text = "Crea Viajes";
            // 
            // button_crearViaje
            // 
            this.button_crearViaje.Location = new System.Drawing.Point(141, 145);
            this.button_crearViaje.Name = "button_crearViaje";
            this.button_crearViaje.Size = new System.Drawing.Size(75, 37);
            this.button_crearViaje.TabIndex = 0;
            this.button_crearViaje.Text = "crear viaje";
            this.button_crearViaje.UseVisualStyleBackColor = true;
            this.button_crearViaje.Click += new System.EventHandler(this.button_crearViaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_listasPasajeros
            // 
            this.groupBox_listasPasajeros.Controls.Add(this.button_verPasajeros);
            this.groupBox_listasPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_listasPasajeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_listasPasajeros.Location = new System.Drawing.Point(713, 3);
            this.groupBox_listasPasajeros.Name = "groupBox_listasPasajeros";
            this.groupBox_listasPasajeros.Size = new System.Drawing.Size(351, 193);
            this.groupBox_listasPasajeros.TabIndex = 5;
            this.groupBox_listasPasajeros.TabStop = false;
            this.groupBox_listasPasajeros.Text = "Datos Pasajeros de un viaje";
            // 
            // button_verPasajeros
            // 
            this.button_verPasajeros.Location = new System.Drawing.Point(126, 145);
            this.button_verPasajeros.Name = "button_verPasajeros";
            this.button_verPasajeros.Size = new System.Drawing.Size(120, 37);
            this.button_verPasajeros.TabIndex = 0;
            this.button_verPasajeros.Text = "Ver Pasajeros";
            this.button_verPasajeros.UseVisualStyleBackColor = true;
            this.button_verPasajeros.Click += new System.EventHandler(this.button_verPasajeros_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox_viajeDisponible.ResumeLayout(false);
            this.groupBox_ventaPasaje.ResumeLayout(false);
            this.groupBox_estadisticas.ResumeLayout(false);
            this.groupBox_CrearViajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_listasPasajeros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox_viajeDisponible;
        private System.Windows.Forms.GroupBox groupBox_ventaPasaje;
        private System.Windows.Forms.Button button_ventaPasaje;
        private System.Windows.Forms.GroupBox groupBox_estadisticas;
        private System.Windows.Forms.Button button_estadisticas;
        private System.Windows.Forms.Button button_ViajesDisponibles;
        private System.Windows.Forms.GroupBox groupBox_CrearViajes;
        private System.Windows.Forms.Button button_crearViaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_listasPasajeros;
        private System.Windows.Forms.Button button_verPasajeros;
    }
}