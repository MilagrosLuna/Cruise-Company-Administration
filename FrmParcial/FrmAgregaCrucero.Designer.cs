
namespace FrmParcial
{
    partial class FrmAgregaCrucero
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
            this.groupBox_crucero = new System.Windows.Forms.GroupBox();
            this.checkedListBox_extrasCrucero = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown_casinos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_salones = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_camarotes = new System.Windows.Forms.NumericUpDown();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxmatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ayuda = new System.Windows.Forms.Button();
            this.button_agregarCrucero = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_crucero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_casinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_camarotes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_crucero, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.89593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.10407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_crucero
            // 
            this.groupBox_crucero.Controls.Add(this.checkedListBox_extrasCrucero);
            this.groupBox_crucero.Controls.Add(this.numericUpDown_casinos);
            this.groupBox_crucero.Controls.Add(this.numericUpDown_salones);
            this.groupBox_crucero.Controls.Add(this.numericUpDown_camarotes);
            this.groupBox_crucero.Controls.Add(this.textBoxnombre);
            this.groupBox_crucero.Controls.Add(this.textBoxmatricula);
            this.groupBox_crucero.Controls.Add(this.label7);
            this.groupBox_crucero.Controls.Add(this.label5);
            this.groupBox_crucero.Controls.Add(this.label4);
            this.groupBox_crucero.Controls.Add(this.label3);
            this.groupBox_crucero.Controls.Add(this.label2);
            this.groupBox_crucero.Controls.Add(this.label1);
            this.groupBox_crucero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_crucero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_crucero.Location = new System.Drawing.Point(3, 3);
            this.groupBox_crucero.Name = "groupBox_crucero";
            this.groupBox_crucero.Size = new System.Drawing.Size(794, 272);
            this.groupBox_crucero.TabIndex = 0;
            this.groupBox_crucero.TabStop = false;
            this.groupBox_crucero.Text = "Datos del crucero";
            // 
            // checkedListBox_extrasCrucero
            // 
            this.checkedListBox_extrasCrucero.FormattingEnabled = true;
            this.checkedListBox_extrasCrucero.Items.AddRange(new object[] {
            "Pileta",
            "Gimnasio",
            "Bares",
            "VideoJuegos"});
            this.checkedListBox_extrasCrucero.Location = new System.Drawing.Point(391, 95);
            this.checkedListBox_extrasCrucero.Name = "checkedListBox_extrasCrucero";
            this.checkedListBox_extrasCrucero.Size = new System.Drawing.Size(149, 100);
            this.checkedListBox_extrasCrucero.TabIndex = 15;
            // 
            // numericUpDown_casinos
            // 
            this.numericUpDown_casinos.Location = new System.Drawing.Point(128, 201);
            this.numericUpDown_casinos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_casinos.Name = "numericUpDown_casinos";
            this.numericUpDown_casinos.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_casinos.TabIndex = 10;
            // 
            // numericUpDown_salones
            // 
            this.numericUpDown_salones.Location = new System.Drawing.Point(128, 166);
            this.numericUpDown_salones.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_salones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_salones.Name = "numericUpDown_salones";
            this.numericUpDown_salones.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_salones.TabIndex = 9;
            this.numericUpDown_salones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_camarotes
            // 
            this.numericUpDown_camarotes.Location = new System.Drawing.Point(128, 129);
            this.numericUpDown_camarotes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_camarotes.Name = "numericUpDown_camarotes";
            this.numericUpDown_camarotes.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_camarotes.TabIndex = 8;
            this.numericUpDown_camarotes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(128, 86);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 29);
            this.textBoxnombre.TabIndex = 7;
            // 
            // textBoxmatricula
            // 
            this.textBoxmatricula.Location = new System.Drawing.Point(128, 42);
            this.textBoxmatricula.Name = "textBoxmatricula";
            this.textBoxmatricula.Size = new System.Drawing.Size(100, 29);
            this.textBoxmatricula.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Extras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Casinos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camarotes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ayuda);
            this.groupBox1.Controls.Add(this.button_agregarCrucero);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_ayuda
            // 
            this.button_ayuda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_ayuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ayuda.Location = new System.Drawing.Point(659, 57);
            this.button_ayuda.Name = "button_ayuda";
            this.button_ayuda.Size = new System.Drawing.Size(126, 70);
            this.button_ayuda.TabIndex = 2;
            this.button_ayuda.Text = "Ayuda";
            this.button_ayuda.UseVisualStyleBackColor = false;
            this.button_ayuda.Click += new System.EventHandler(this.button_ayuda_Click);
            // 
            // button_agregarCrucero
            // 
            this.button_agregarCrucero.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_agregarCrucero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_agregarCrucero.Location = new System.Drawing.Point(6, 57);
            this.button_agregarCrucero.Name = "button_agregarCrucero";
            this.button_agregarCrucero.Size = new System.Drawing.Size(126, 70);
            this.button_agregarCrucero.TabIndex = 1;
            this.button_agregarCrucero.Text = "Crear";
            this.button_agregarCrucero.UseVisualStyleBackColor = false;
            this.button_agregarCrucero.Click += new System.EventHandler(this.button_agregarCrucero_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmAgregaCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAgregaCrucero";
            this.Text = "FrmAgregaCrucero";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_crucero.ResumeLayout(false);
            this.groupBox_crucero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_casinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_camarotes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_crucero;
        private System.Windows.Forms.Button button_agregarCrucero;
        private System.Windows.Forms.TextBox textBoxmatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.NumericUpDown numericUpDown_camarotes;
        private System.Windows.Forms.NumericUpDown numericUpDown_casinos;
        private System.Windows.Forms.NumericUpDown numericUpDown_salones;
        private System.Windows.Forms.CheckedListBox checkedListBox_extrasCrucero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ayuda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}