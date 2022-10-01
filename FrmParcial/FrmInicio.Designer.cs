
namespace FrmParcial
{
    partial class FrmInicio
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
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_LogIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_inicio, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 287);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LogIn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_LogIn.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LogIn.Location = new System.Drawing.Point(261, 200);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(124, 58);
            this.btn_LogIn.TabIndex = 0;
            this.btn_LogIn.Text = "Ingresar";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_inicio.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_inicio.Location = new System.Drawing.Point(41, 29);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(564, 114);
            this.lbl_inicio.TabIndex = 1;
            this.lbl_inicio.Text = "BIENVENIDO A CRUCEROS FRIOLITO";
            this.lbl_inicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 287);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_inicio;
    }
}