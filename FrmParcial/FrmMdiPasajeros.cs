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
    public partial class FrmMdiPasajeros : Form
    {
        private bool regionalMdi = false;
        public FrmMdiPasajeros(bool regional)
        {
            InitializeComponent();
            if (regional)
            {
                regionalMdi = true;
                dataGridView_viajes.DataSource = Compañia.viajesRegionales;
            }
            else
            {
                dataGridView_viajes.DataSource = Compañia.viajesExtraRegionales;
            }
        }

        private void button_verPasajeros_Click(object sender, EventArgs e)
        {
            if (regionalMdi)
            {
                dataGridView_pasajeros.DataSource = null;
                dataGridView_pasajeros.DataSource = Compañia.viajesRegionales[dataGridView_viajes.CurrentCell.RowIndex].ListaPasajeros;
            }
            else
            {
                dataGridView_pasajeros.DataSource = null;
                dataGridView_pasajeros.DataSource = Compañia.viajesExtraRegionales[dataGridView_viajes.CurrentCell.RowIndex].ListaPasajeros;
            }
            
        }
    }
}
