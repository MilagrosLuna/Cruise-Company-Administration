
namespace FrmParcial
{
    partial class FrmInicioVenta
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
            this.groupBox_clase = new System.Windows.Forms.GroupBox();
            this.radioButton_Turista = new System.Windows.Forms.RadioButton();
            this.radioButton_premium = new System.Windows.Forms.RadioButton();
            this.groupBox_viaje = new System.Windows.Forms.GroupBox();
            this.radioButton_extraRegional = new System.Windows.Forms.RadioButton();
            this.radioButton_regional = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_clase.SuspendLayout();
            this.groupBox_viaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_clase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_viaje, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_help, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.49807F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.50193F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_clase
            // 
            this.groupBox_clase.Controls.Add(this.radioButton_Turista);
            this.groupBox_clase.Controls.Add(this.radioButton_premium);
            this.groupBox_clase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_clase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_clase.Location = new System.Drawing.Point(213, 3);
            this.groupBox_clase.Name = "groupBox_clase";
            this.groupBox_clase.Size = new System.Drawing.Size(204, 140);
            this.groupBox_clase.TabIndex = 0;
            this.groupBox_clase.TabStop = false;
            this.groupBox_clase.Text = "Clase ";
            // 
            // radioButton_Turista
            // 
            this.radioButton_Turista.AutoSize = true;
            this.radioButton_Turista.Checked = true;
            this.radioButton_Turista.Location = new System.Drawing.Point(6, 42);
            this.radioButton_Turista.Name = "radioButton_Turista";
            this.radioButton_Turista.Size = new System.Drawing.Size(75, 25);
            this.radioButton_Turista.TabIndex = 3;
            this.radioButton_Turista.TabStop = true;
            this.radioButton_Turista.Text = "Turista";
            this.radioButton_Turista.UseVisualStyleBackColor = true;
            // 
            // radioButton_premium
            // 
            this.radioButton_premium.AutoSize = true;
            this.radioButton_premium.Location = new System.Drawing.Point(6, 73);
            this.radioButton_premium.Name = "radioButton_premium";
            this.radioButton_premium.Size = new System.Drawing.Size(92, 25);
            this.radioButton_premium.TabIndex = 2;
            this.radioButton_premium.Text = "Premium";
            this.radioButton_premium.UseVisualStyleBackColor = true;
            // 
            // groupBox_viaje
            // 
            this.groupBox_viaje.Controls.Add(this.radioButton_extraRegional);
            this.groupBox_viaje.Controls.Add(this.radioButton_regional);
            this.groupBox_viaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_viaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_viaje.Location = new System.Drawing.Point(3, 3);
            this.groupBox_viaje.Name = "groupBox_viaje";
            this.groupBox_viaje.Size = new System.Drawing.Size(204, 140);
            this.groupBox_viaje.TabIndex = 1;
            this.groupBox_viaje.TabStop = false;
            this.groupBox_viaje.Text = "Viaje";
            // 
            // radioButton_extraRegional
            // 
            this.radioButton_extraRegional.AutoSize = true;
            this.radioButton_extraRegional.Location = new System.Drawing.Point(9, 73);
            this.radioButton_extraRegional.Name = "radioButton_extraRegional";
            this.radioButton_extraRegional.Size = new System.Drawing.Size(127, 25);
            this.radioButton_extraRegional.TabIndex = 1;
            this.radioButton_extraRegional.Text = "Extra Regional";
            this.radioButton_extraRegional.UseVisualStyleBackColor = true;
            // 
            // radioButton_regional
            // 
            this.radioButton_regional.AutoSize = true;
            this.radioButton_regional.Checked = true;
            this.radioButton_regional.Location = new System.Drawing.Point(9, 42);
            this.radioButton_regional.Name = "radioButton_regional";
            this.radioButton_regional.Size = new System.Drawing.Size(89, 25);
            this.radioButton_regional.TabIndex = 0;
            this.radioButton_regional.TabStop = true;
            this.radioButton_regional.Text = "Regional";
            this.radioButton_regional.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Location = new System.Drawing.Point(213, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_help.Location = new System.Drawing.Point(3, 149);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(75, 23);
            this.button_help.TabIndex = 3;
            this.button_help.Text = "ayuda";
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // FrmInicioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(420, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmInicioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicioVenta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_clase.ResumeLayout(false);
            this.groupBox_clase.PerformLayout();
            this.groupBox_viaje.ResumeLayout(false);
            this.groupBox_viaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_clase;
        private System.Windows.Forms.RadioButton radioButton_Turista;
        private System.Windows.Forms.RadioButton radioButton_premium;
        private System.Windows.Forms.GroupBox groupBox_viaje;
        private System.Windows.Forms.RadioButton radioButton_extraRegional;
        private System.Windows.Forms.RadioButton radioButton_regional;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_help;
    }
}