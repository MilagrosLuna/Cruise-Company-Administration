﻿
namespace FrmParcial
{
    partial class FrmPasajePremium
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
            this.comboBox_nacion = new System.Windows.Forms.ComboBox();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.comboBox_valija = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_crearPasajero
            // 
            this.button_crearPasajero.Click += new System.EventHandler(this.button_crearPasajero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_valija);
            this.groupBox1.Controls.Add(this.comboBox_genero);
            this.groupBox1.Controls.Add(this.comboBox_nacion);
            this.groupBox1.Text = "datos";
            this.groupBox1.Controls.SetChildIndex(this.textBox_numPasaporte, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox3_edad, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox_apellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton_NoBolso, 0);
            this.groupBox1.Controls.SetChildIndex(this.radioButton_siBolso, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox_name, 0);
            this.groupBox1.Controls.SetChildIndex(this.button_crearPasajero, 0);
            this.groupBox1.Controls.SetChildIndex(this.button_agregarValija, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox_nacion, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox_genero, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox_valija, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Text = "viaje";
            // 
            // button_agregarValija
            // 
            this.button_agregarValija.Click += new System.EventHandler(this.button_agregarValija_Click);
            // 
            // comboBox_nacion
            // 
            this.comboBox_nacion.FormattingEnabled = true;
            this.comboBox_nacion.Location = new System.Drawing.Point(155, 191);
            this.comboBox_nacion.Name = "comboBox_nacion";
            this.comboBox_nacion.Size = new System.Drawing.Size(116, 23);
            this.comboBox_nacion.TabIndex = 38;
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Location = new System.Drawing.Point(154, 156);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(101, 23);
            this.comboBox_genero.TabIndex = 39;
            // 
            // comboBox_valija
            // 
            this.comboBox_valija.FormattingEnabled = true;
            this.comboBox_valija.Location = new System.Drawing.Point(502, 191);
            this.comboBox_valija.Name = "comboBox_valija";
            this.comboBox_valija.Size = new System.Drawing.Size(121, 23);
            this.comboBox_valija.TabIndex = 40;
            // 
            // FrmPasajePremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 575);
            this.MinimumSize = new System.Drawing.Size(783, 614);
            this.Name = "FrmPasajePremium";
            this.Text = "Pasaje Premium";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_nacion;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.ComboBox comboBox_valija;
    }
}