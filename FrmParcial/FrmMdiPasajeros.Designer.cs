
namespace FrmParcial
{
    partial class FrmMdiPasajeros
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
            this.dataGridView_viajes = new System.Windows.Forms.DataGridView();
            this.dataGridView_pasajeros = new System.Windows.Forms.DataGridView();
            this.button_verPasajeros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ayuda = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pasajeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_viajes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_pasajeros, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_viajes
            // 
            this.dataGridView_viajes.AllowUserToAddRows = false;
            this.dataGridView_viajes.AllowUserToDeleteRows = false;
            this.dataGridView_viajes.AllowUserToOrderColumns = true;
            this.dataGridView_viajes.AllowUserToResizeColumns = false;
            this.dataGridView_viajes.AllowUserToResizeRows = false;
            this.dataGridView_viajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_viajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_viajes.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_viajes.Name = "dataGridView_viajes";
            this.dataGridView_viajes.RowTemplate.Height = 25;
            this.dataGridView_viajes.Size = new System.Drawing.Size(842, 218);
            this.dataGridView_viajes.TabIndex = 2;
            // 
            // dataGridView_pasajeros
            // 
            this.dataGridView_pasajeros.AllowUserToAddRows = false;
            this.dataGridView_pasajeros.AllowUserToDeleteRows = false;
            this.dataGridView_pasajeros.AllowUserToResizeColumns = false;
            this.dataGridView_pasajeros.AllowUserToResizeRows = false;
            this.dataGridView_pasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_pasajeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_pasajeros.Location = new System.Drawing.Point(3, 291);
            this.dataGridView_pasajeros.Name = "dataGridView_pasajeros";
            this.dataGridView_pasajeros.RowTemplate.Height = 25;
            this.dataGridView_pasajeros.Size = new System.Drawing.Size(842, 219);
            this.dataGridView_pasajeros.TabIndex = 3;
            // 
            // button_verPasajeros
            // 
            this.button_verPasajeros.BackColor = System.Drawing.Color.MediumPurple;
            this.button_verPasajeros.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_verPasajeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_verPasajeros.Location = new System.Drawing.Point(3, 19);
            this.button_verPasajeros.Name = "button_verPasajeros";
            this.button_verPasajeros.Size = new System.Drawing.Size(180, 36);
            this.button_verPasajeros.TabIndex = 4;
            this.button_verPasajeros.Text = "Ver Pasajeros";
            this.button_verPasajeros.UseVisualStyleBackColor = false;
            this.button_verPasajeros.Click += new System.EventHandler(this.button_verPasajeros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ayuda);
            this.groupBox1.Controls.Add(this.button_verPasajeros);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_ayuda
            // 
            this.button_ayuda.BackColor = System.Drawing.Color.MediumPurple;
            this.button_ayuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ayuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ayuda.Location = new System.Drawing.Point(745, 19);
            this.button_ayuda.Name = "button_ayuda";
            this.button_ayuda.Size = new System.Drawing.Size(94, 36);
            this.button_ayuda.TabIndex = 5;
            this.button_ayuda.Text = "ayuda";
            this.button_ayuda.UseVisualStyleBackColor = false;
            this.button_ayuda.Click += new System.EventHandler(this.button_ayuda_Click);
            // 
            // FrmMdiPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 513);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMdiPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMdiPasajeros";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pasajeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_viajes;
        private System.Windows.Forms.DataGridView dataGridView_pasajeros;
        private System.Windows.Forms.Button button_verPasajeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ayuda;
    }
}