
namespace FrmParcial
{
    partial class FrmCreaViaje
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_seleccionarDestino = new System.Windows.Forms.GroupBox();
            this.button_ayuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_verDestinos = new System.Windows.Forms.Button();
            this.radioButton_extraRegional = new System.Windows.Forms.RadioButton();
            this.radioButton_regional = new System.Windows.Forms.RadioButton();
            this.groupBox_crear = new System.Windows.Forms.GroupBox();
            this.comboBox_seleccionarDestino = new System.Windows.Forms.ComboBox();
            this.label_destino = new System.Windows.Forms.Label();
            this.button_crearViaje = new System.Windows.Forms.Button();
            this.comboBox_Embarcaciones = new System.Windows.Forms.ComboBox();
            this.label_embarcacion = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.dateTimePicker_Partida = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_seleccionarDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_crear.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_seleccionarDestino, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_crear, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1313, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_seleccionarDestino
            // 
            this.groupBox_seleccionarDestino.Controls.Add(this.button_ayuda);
            this.groupBox_seleccionarDestino.Controls.Add(this.pictureBox1);
            this.groupBox_seleccionarDestino.Controls.Add(this.button_verDestinos);
            this.groupBox_seleccionarDestino.Controls.Add(this.radioButton_extraRegional);
            this.groupBox_seleccionarDestino.Controls.Add(this.radioButton_regional);
            this.groupBox_seleccionarDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_seleccionarDestino.Location = new System.Drawing.Point(3, 3);
            this.groupBox_seleccionarDestino.Name = "groupBox_seleccionarDestino";
            this.groupBox_seleccionarDestino.Size = new System.Drawing.Size(1307, 147);
            this.groupBox_seleccionarDestino.TabIndex = 0;
            this.groupBox_seleccionarDestino.TabStop = false;
            this.groupBox_seleccionarDestino.Text = "Ver Destinos";
            // 
            // button_ayuda
            // 
            this.button_ayuda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_ayuda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ayuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ayuda.Location = new System.Drawing.Point(785, 62);
            this.button_ayuda.Name = "button_ayuda";
            this.button_ayuda.Size = new System.Drawing.Size(90, 46);
            this.button_ayuda.TabIndex = 4;
            this.button_ayuda.Text = "Ayuda";
            this.button_ayuda.UseVisualStyleBackColor = false;
            this.button_ayuda.Click += new System.EventHandler(this.button_ayuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::FrmParcial.Properties.Resources.trabajar_en_un_crucero;
            this.pictureBox1.Location = new System.Drawing.Point(1011, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_verDestinos
            // 
            this.button_verDestinos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_verDestinos.Location = new System.Drawing.Point(123, 85);
            this.button_verDestinos.Name = "button_verDestinos";
            this.button_verDestinos.Size = new System.Drawing.Size(107, 23);
            this.button_verDestinos.TabIndex = 2;
            this.button_verDestinos.Text = "Ver destinos";
            this.button_verDestinos.UseVisualStyleBackColor = true;
            this.button_verDestinos.Click += new System.EventHandler(this.button_verDestinos_Click);
            // 
            // radioButton_extraRegional
            // 
            this.radioButton_extraRegional.AutoSize = true;
            this.radioButton_extraRegional.Location = new System.Drawing.Point(194, 26);
            this.radioButton_extraRegional.Name = "radioButton_extraRegional";
            this.radioButton_extraRegional.Size = new System.Drawing.Size(100, 19);
            this.radioButton_extraRegional.TabIndex = 1;
            this.radioButton_extraRegional.Text = "Extra Regional";
            this.radioButton_extraRegional.UseVisualStyleBackColor = true;
            // 
            // radioButton_regional
            // 
            this.radioButton_regional.AutoSize = true;
            this.radioButton_regional.Checked = true;
            this.radioButton_regional.Location = new System.Drawing.Point(85, 26);
            this.radioButton_regional.Name = "radioButton_regional";
            this.radioButton_regional.Size = new System.Drawing.Size(71, 19);
            this.radioButton_regional.TabIndex = 0;
            this.radioButton_regional.TabStop = true;
            this.radioButton_regional.Text = "Regional";
            this.radioButton_regional.UseVisualStyleBackColor = true;
            // 
            // groupBox_crear
            // 
            this.groupBox_crear.Controls.Add(this.comboBox_seleccionarDestino);
            this.groupBox_crear.Controls.Add(this.label_destino);
            this.groupBox_crear.Controls.Add(this.button_crearViaje);
            this.groupBox_crear.Controls.Add(this.comboBox_Embarcaciones);
            this.groupBox_crear.Controls.Add(this.label_embarcacion);
            this.groupBox_crear.Controls.Add(this.label_fecha);
            this.groupBox_crear.Controls.Add(this.dateTimePicker_Partida);
            this.groupBox_crear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_crear.Location = new System.Drawing.Point(3, 156);
            this.groupBox_crear.Name = "groupBox_crear";
            this.groupBox_crear.Size = new System.Drawing.Size(1307, 177);
            this.groupBox_crear.TabIndex = 2;
            this.groupBox_crear.TabStop = false;
            this.groupBox_crear.Text = "Informacion del viaje";
            // 
            // comboBox_seleccionarDestino
            // 
            this.comboBox_seleccionarDestino.FormattingEnabled = true;
            this.comboBox_seleccionarDestino.Location = new System.Drawing.Point(144, 37);
            this.comboBox_seleccionarDestino.Name = "comboBox_seleccionarDestino";
            this.comboBox_seleccionarDestino.Size = new System.Drawing.Size(171, 23);
            this.comboBox_seleccionarDestino.TabIndex = 6;
            // 
            // label_destino
            // 
            this.label_destino.AutoSize = true;
            this.label_destino.Location = new System.Drawing.Point(18, 40);
            this.label_destino.Name = "label_destino";
            this.label_destino.Size = new System.Drawing.Size(47, 15);
            this.label_destino.TabIndex = 5;
            this.label_destino.Text = "Destino";
            // 
            // button_crearViaje
            // 
            this.button_crearViaje.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_crearViaje.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_crearViaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_crearViaje.Location = new System.Drawing.Point(546, 40);
            this.button_crearViaje.Name = "button_crearViaje";
            this.button_crearViaje.Size = new System.Drawing.Size(106, 48);
            this.button_crearViaje.TabIndex = 4;
            this.button_crearViaje.Text = "Crear";
            this.button_crearViaje.UseVisualStyleBackColor = false;
            this.button_crearViaje.Click += new System.EventHandler(this.button_crearViaje_Click);
            // 
            // comboBox_Embarcaciones
            // 
            this.comboBox_Embarcaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox_Embarcaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Embarcaciones.FormattingEnabled = true;
            this.comboBox_Embarcaciones.Location = new System.Drawing.Point(3, 151);
            this.comboBox_Embarcaciones.Name = "comboBox_Embarcaciones";
            this.comboBox_Embarcaciones.Size = new System.Drawing.Size(1301, 23);
            this.comboBox_Embarcaciones.TabIndex = 3;
            // 
            // label_embarcacion
            // 
            this.label_embarcacion.AutoSize = true;
            this.label_embarcacion.Location = new System.Drawing.Point(18, 128);
            this.label_embarcacion.Name = "label_embarcacion";
            this.label_embarcacion.Size = new System.Drawing.Size(76, 15);
            this.label_embarcacion.TabIndex = 2;
            this.label_embarcacion.Text = "Embarcacion";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(18, 85);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(97, 15);
            this.label_fecha.TabIndex = 1;
            this.label_fecha.Text = "Fecha de  partida";
            // 
            // dateTimePicker_Partida
            // 
            this.dateTimePicker_Partida.Location = new System.Drawing.Point(144, 85);
            this.dateTimePicker_Partida.Name = "dateTimePicker_Partida";
            this.dateTimePicker_Partida.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker_Partida.TabIndex = 0;
            // 
            // FrmCreaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1329, 375);
            this.Name = "FrmCreaViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear viaje";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_seleccionarDestino.ResumeLayout(false);
            this.groupBox_seleccionarDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_crear.ResumeLayout(false);
            this.groupBox_crear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_seleccionarDestino;
        private System.Windows.Forms.RadioButton radioButton_extraRegional;
        private System.Windows.Forms.RadioButton radioButton_regional;
        private System.Windows.Forms.Button button_verDestinos;
        private System.Windows.Forms.GroupBox groupBox_crear;
        private System.Windows.Forms.Label label_embarcacion;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Partida;
        private System.Windows.Forms.ComboBox comboBox_Embarcaciones;
        private System.Windows.Forms.Button button_crearViaje;
        private System.Windows.Forms.Label label_destino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_seleccionarDestino;
        private System.Windows.Forms.Button button_ayuda;
    }
}