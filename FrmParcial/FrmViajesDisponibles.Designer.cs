
namespace FrmParcial
{
    partial class FrmViajesDisponibles
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
            this.label_Extraregionales = new System.Windows.Forms.Label();
            this.label_regionales = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Regionales = new System.Windows.Forms.DataGridView();
            this.dataGridView_extraRegionales = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Regionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_extraRegionales)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Extraregionales
            // 
            this.label_Extraregionales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Extraregionales.AutoSize = true;
            this.label_Extraregionales.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_Extraregionales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Extraregionales.Location = new System.Drawing.Point(564, 361);
            this.label_Extraregionales.Name = "label_Extraregionales";
            this.label_Extraregionales.Size = new System.Drawing.Size(165, 30);
            this.label_Extraregionales.TabIndex = 7;
            this.label_Extraregionales.Text = "Extra Regionales";
            // 
            // label_regionales
            // 
            this.label_regionales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_regionales.AutoSize = true;
            this.label_regionales.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_regionales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_regionales.Location = new System.Drawing.Point(590, 34);
            this.label_regionales.Name = "label_regionales";
            this.label_regionales.Size = new System.Drawing.Size(113, 30);
            this.label_regionales.TabIndex = 6;
            this.label_regionales.Text = "Regionales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Regionales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_regionales, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_extraRegionales, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Extraregionales, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.11628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_Regionales
            // 
            this.dataGridView_Regionales.AllowUserToAddRows = false;
            this.dataGridView_Regionales.AllowUserToDeleteRows = false;
            this.dataGridView_Regionales.AllowUserToResizeColumns = false;
            this.dataGridView_Regionales.AllowUserToResizeRows = false;
            this.dataGridView_Regionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Regionales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_Regionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Regionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Regionales.Location = new System.Drawing.Point(3, 102);
            this.dataGridView_Regionales.Name = "dataGridView_Regionales";
            this.dataGridView_Regionales.RowTemplate.Height = 25;
            this.dataGridView_Regionales.Size = new System.Drawing.Size(1287, 222);
            this.dataGridView_Regionales.TabIndex = 8;
            // 
            // dataGridView_extraRegionales
            // 
            this.dataGridView_extraRegionales.AllowUserToAddRows = false;
            this.dataGridView_extraRegionales.AllowUserToDeleteRows = false;
            this.dataGridView_extraRegionales.AllowUserToResizeColumns = false;
            this.dataGridView_extraRegionales.AllowUserToResizeRows = false;
            this.dataGridView_extraRegionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_extraRegionales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_extraRegionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_extraRegionales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_extraRegionales.Location = new System.Drawing.Point(3, 429);
            this.dataGridView_extraRegionales.Name = "dataGridView_extraRegionales";
            this.dataGridView_extraRegionales.ReadOnly = true;
            this.dataGridView_extraRegionales.RowTemplate.Height = 25;
            this.dataGridView_extraRegionales.Size = new System.Drawing.Size(1287, 224);
            this.dataGridView_extraRegionales.TabIndex = 9;
            // 
            // FrmViajesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmViajesDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmViajesDisponibles";
            this.Load += new System.EventHandler(this.FrmViajesDisponibles_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Regionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_extraRegionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Extraregionales;
        private System.Windows.Forms.Label label_regionales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Regionales;
        private System.Windows.Forms.DataGridView dataGridView_extraRegionales;
    }
}