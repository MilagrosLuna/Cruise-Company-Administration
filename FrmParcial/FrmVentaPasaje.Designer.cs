
namespace FrmParcial
{
    partial class FrmVentaPasaje
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
            this.button_crearPasajero = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_numPasaporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_viaje = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_genero = new System.Windows.Forms.Label();
            this.button_agregarValija = new System.Windows.Forms.Button();
            this.label_Valija = new System.Windows.Forms.Label();
            this.radioButton_siBolso = new System.Windows.Forms.RadioButton();
            this.radioButton_NoBolso = new System.Windows.Forms.RadioButton();
            this.label_Bolso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ayuda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viaje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_crearPasajero
            // 
            this.button_crearPasajero.Location = new System.Drawing.Point(350, 310);
            this.button_crearPasajero.Name = "button_crearPasajero";
            this.button_crearPasajero.Size = new System.Drawing.Size(91, 23);
            this.button_crearPasajero.TabIndex = 2;
            this.button_crearPasajero.Text = "Crear Pasajero";
            this.button_crearPasajero.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox_numPasaporte
            // 
            this.textBox_numPasaporte.Location = new System.Drawing.Point(155, 225);
            this.textBox_numPasaporte.Name = "textBox_numPasaporte";
            this.textBox_numPasaporte.Size = new System.Drawing.Size(100, 23);
            this.textBox_numPasaporte.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de expiracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero de pasaporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // textBox3_edad
            // 
            this.textBox3_edad.Location = new System.Drawing.Point(154, 124);
            this.textBox3_edad.Name = "textBox3_edad";
            this.textBox3_edad.Size = new System.Drawing.Size(100, 23);
            this.textBox3_edad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(154, 91);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 23);
            this.textBox_apellido.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(154, 59);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 596);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_viaje);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 215);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView_viaje
            // 
            this.dataGridView_viaje.AllowUserToAddRows = false;
            this.dataGridView_viaje.AllowUserToDeleteRows = false;
            this.dataGridView_viaje.AllowUserToOrderColumns = true;
            this.dataGridView_viaje.AllowUserToResizeColumns = false;
            this.dataGridView_viaje.AllowUserToResizeRows = false;
            this.dataGridView_viaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_viaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_viaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_viaje.Location = new System.Drawing.Point(3, 19);
            this.dataGridView_viaje.Name = "dataGridView_viaje";
            this.dataGridView_viaje.ReadOnly = true;
            this.dataGridView_viaje.RowTemplate.Height = 25;
            this.dataGridView_viaje.Size = new System.Drawing.Size(904, 193);
            this.dataGridView_viaje.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ayuda);
            this.groupBox1.Controls.Add(this.label_genero);
            this.groupBox1.Controls.Add(this.button_agregarValija);
            this.groupBox1.Controls.Add(this.button_crearPasajero);
            this.groupBox1.Controls.Add(this.label_Valija);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.radioButton_siBolso);
            this.groupBox1.Controls.Add(this.radioButton_NoBolso);
            this.groupBox1.Controls.Add(this.textBox_apellido);
            this.groupBox1.Controls.Add(this.label_Bolso);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3_edad);
            this.groupBox1.Controls.Add(this.textBox_numPasaporte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 596);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(17, 159);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(45, 15);
            this.label_genero.TabIndex = 36;
            this.label_genero.Text = "Genero";
            // 
            // button_agregarValija
            // 
            this.button_agregarValija.Location = new System.Drawing.Point(502, 224);
            this.button_agregarValija.Name = "button_agregarValija";
            this.button_agregarValija.Size = new System.Drawing.Size(94, 23);
            this.button_agregarValija.TabIndex = 34;
            this.button_agregarValija.Text = "Agregar Valija";
            this.button_agregarValija.UseVisualStyleBackColor = true;
            // 
            // label_Valija
            // 
            this.label_Valija.AutoSize = true;
            this.label_Valija.Location = new System.Drawing.Point(502, 159);
            this.label_Valija.Name = "label_Valija";
            this.label_Valija.Size = new System.Drawing.Size(34, 15);
            this.label_Valija.TabIndex = 33;
            this.label_Valija.Text = "Valija";
            // 
            // radioButton_siBolso
            // 
            this.radioButton_siBolso.AutoSize = true;
            this.radioButton_siBolso.Location = new System.Drawing.Point(502, 109);
            this.radioButton_siBolso.Name = "radioButton_siBolso";
            this.radioButton_siBolso.Size = new System.Drawing.Size(61, 19);
            this.radioButton_siBolso.TabIndex = 32;
            this.radioButton_siBolso.TabStop = true;
            this.radioButton_siBolso.Text = "Si lleva";
            this.radioButton_siBolso.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoBolso
            // 
            this.radioButton_NoBolso.AutoSize = true;
            this.radioButton_NoBolso.Location = new System.Drawing.Point(502, 83);
            this.radioButton_NoBolso.Name = "radioButton_NoBolso";
            this.radioButton_NoBolso.Size = new System.Drawing.Size(68, 19);
            this.radioButton_NoBolso.TabIndex = 31;
            this.radioButton_NoBolso.TabStop = true;
            this.radioButton_NoBolso.Text = "No lleva";
            this.radioButton_NoBolso.UseVisualStyleBackColor = true;
            // 
            // label_Bolso
            // 
            this.label_Bolso.AutoSize = true;
            this.label_Bolso.Location = new System.Drawing.Point(502, 46);
            this.label_Bolso.Name = "label_Bolso";
            this.label_Bolso.Size = new System.Drawing.Size(86, 15);
            this.label_Bolso.TabIndex = 30;
            this.label_Bolso.Text = "Bolso de mano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nacionalidad";
            // 
            // button_ayuda
            // 
            this.button_ayuda.Location = new System.Drawing.Point(686, 309);
            this.button_ayuda.Name = "button_ayuda";
            this.button_ayuda.Size = new System.Drawing.Size(75, 23);
            this.button_ayuda.TabIndex = 37;
            this.button_ayuda.Text = "Ayuda";
            this.button_ayuda.UseVisualStyleBackColor = true;
            this.button_ayuda.Click += new System.EventHandler(this.button_ayuda_Click);
            // 
            // FrmVentaPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(910, 596);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVentaPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentaPasaje";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viaje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button button_crearPasajero;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.TextBox textBox_numPasaporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox3_edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBox_apellido;
        protected System.Windows.Forms.TextBox textBox_name;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.DataGridView dataGridView_viaje;
        protected System.Windows.Forms.Button button_agregarValija;
        private System.Windows.Forms.Label label_Valija;
        protected System.Windows.Forms.RadioButton radioButton_siBolso;
        protected System.Windows.Forms.RadioButton radioButton_NoBolso;
        private System.Windows.Forms.Label label_Bolso;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ayuda;
    }
}