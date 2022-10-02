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
        private List<Pasajero> pasajeros;
        public FrmMdiPasajeros(bool regional)
        {
            pasajeros = new List<Pasajero>();
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
            pasajeros.Clear();
            if (regionalMdi)
            {

                for(int i=0;i < Compañia.viajesRegionales[dataGridView_viajes.CurrentCell.RowIndex].CantidadPasajeros;i++)
                {
                    pasajeros.Add(Compañia.viajesRegionales[dataGridView_viajes.CurrentCell.RowIndex][i]);
                }
                dataGridView_pasajeros.DataSource = null;
                dataGridView_pasajeros.DataSource = pasajeros;
                //dataGridView_pasajeros.DataSource = null;
                //dataGridView_pasajeros.DataSource = Compañia.viajesRegionales[dataGridView_viajes.CurrentCell.RowIndex].ListaPasajeros;
            }
            else
            {
                for (int i = 0; i < Compañia.viajesExtraRegionales[dataGridView_viajes.CurrentCell.RowIndex].CantidadPasajeros; i++)
                {
                    pasajeros.Add(Compañia.viajesExtraRegionales[dataGridView_viajes.CurrentCell.RowIndex][i]);
                }
                dataGridView_pasajeros.DataSource = null;
                dataGridView_pasajeros.DataSource = pasajeros;
                //dataGridView_pasajeros.DataSource = null;
                //dataGridView_pasajeros.DataSource = Compañia.viajesExtraRegionales[dataGridView_viajes.CurrentCell.RowIndex].ListaPasajeros;
            }
            
        }

        private void button_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seleccione un viaje y luego pulse \n el boton ver pasajeros", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
