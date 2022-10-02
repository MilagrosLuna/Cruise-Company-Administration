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
    public partial class FrmEstadisticas : Form
    {
        DataTable destinosDatosDataTable;
        DataView destinosDataView;

        public FrmEstadisticas()
        {
            InitializeComponent();
            destinosDatosDataTable = new DataTable();
            destinosDataView = destinosDatosDataTable.DefaultView;
            CrearTabla();
        }
        private void CrearTabla()
        {
            destinosDatosDataTable.Columns.Add("Destino", typeof(string));
            destinosDatosDataTable.Columns.Add("Viajes", typeof(string));
            destinosDatosDataTable.Columns.Add("Pasajeros", typeof(string));
            destinosDatosDataTable.Columns.Add("Recaudacion", typeof(string));
            foreach (Destinos item in Estadisticas.destinos)
            {
                string destino = item.Destino;
                string viajes = item.CantidadViajes.ToString();
                string pasajeros = item.CantidadPasajeros.ToString();
                string recaudacion = item.Recaudacion.ToString();
                destinosDatosDataTable.Rows.Add(destino, viajes, pasajeros, recaudacion);
            }
            dataGridView1.DataSource = destinosDatosDataTable;
        }
    }
}
