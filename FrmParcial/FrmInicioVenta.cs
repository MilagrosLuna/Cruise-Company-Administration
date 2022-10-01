using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesParcial;

namespace FrmParcial
{
    public partial class FrmInicioVenta : Form
    {
        private FrmPasajeTurista frmTurista;
        private FrmPasajePremium frmPremium;
        public FrmInicioVenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton_Turista.Checked)
            {
                if(EsRegionalONo())
                {
                    this.frmTurista = new FrmPasajeTurista(true);
                    this.frmTurista.ShowDialog();
                }
                else
                {
                    this.frmTurista = new FrmPasajeTurista(false);
                    this.frmTurista.ShowDialog();
                }
                
            }
            if(radioButton_premium.Checked)
            {
                if (EsRegionalONo())
                {
                    this.frmPremium = new FrmPasajePremium(true);
                    this.frmPremium.ShowDialog();
                }
                else
                {
                    this.frmPremium = new FrmPasajePremium(false);
                    this.frmPremium.ShowDialog();
                }

            }
        }
        private bool EsRegionalONo()
        {
            return radioButton_regional.Checked;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seleccione los datos para el pasajero", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
