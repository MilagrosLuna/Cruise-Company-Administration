using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmInicio : Form
    {
        private int bandera = 0;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            this.bandera = 1;
            this.Visible = false;
            FrmLogin frmLOG= new FrmLogin();
            frmLOG.ShowDialog();
            this.Close();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bandera==0)
            {
                if (MessageBox.Show("¿Esta seguro de salir de la aplicacion?", "atencion!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
