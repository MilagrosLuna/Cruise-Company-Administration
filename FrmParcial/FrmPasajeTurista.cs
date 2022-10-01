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
    public partial class FrmPasajeTurista : FrmVentaPasaje
    {
        private Bolsos valija;
        private bool bandera;
        public FrmPasajeTurista(bool regionalONo)
        {
            InitializeComponent();

            List<string> genero = new List<string>(Enum.GetNames(typeof(Sexo)).ToArray());
            genero.RemoveAt(0);
            comboBox_genero.DataSource = genero;

            List<string> nacionalidades = new List<string>(Enum.GetNames(typeof(Nacionalidad)).ToArray());
            nacionalidades.RemoveAt(0);
            comboBox1_nacion.DataSource = nacionalidades;

            comboBox_valija.DataSource = Compañia.listaPesosValija;

            // para ver q lista mostrar en el data grid, despues en el paso de info al datagrid verifico q no sea nula y la muestro
            if (regionalONo==true)
            {
                bandera = true;
                base.dataGridView_viaje.DataSource = Compañia.viajesRegionales;
            }
            else
            {
                base.dataGridView_viaje.DataSource = Compañia.viajesExtraRegionales;
            }
        }

        private void button_agregarValija_Click(object sender, EventArgs e)
        {
            if(banderaValija==0)
            {
                banderaValija = 1;// se cargo una valija
                valija = new Bolsos(comboBox_valija.SelectedIndex, Equipaje.De_Bodega);
            }
        }

        private void button_crearPasajero_Click(object sender, EventArgs e)
        {
            if (base.Validar() == true)
            {
                string name = textBox_name.Text;
                string apellido = textBox_apellido.Text;
                int numPasaporte = int.Parse(textBox_numPasaporte.Text);
                Nacionalidad nacionalidad = (Nacionalidad)comboBox1_nacion.SelectedIndex;
                Pasaporte pasaporte = new Pasaporte(dateTimePicker1.Value, numPasaporte, nacionalidad);
                int edad = int.Parse(textBox3_edad.Text);
                Sexo genero = (Sexo)comboBox_genero.SelectedIndex;
                Cliente cliente = new Cliente(name, apellido, pasaporte, edad, genero);
                TipoPasajero tipoPasajero = TipoPasajero.Turista;
                Pasajero pasajero = new Pasajero(cliente, tipoPasajero);
                pasajero = pasajero + valija;

                if(radioButton_siBolso.Checked)
                {
                    Bolsos bolsomano = new Bolsos(1, Equipaje.De_Mano);
                    pasajero = pasajero + bolsomano;
                }

                if (bandera == true)
                {
                    if (Compañia.viajesRegionales[dataGridView_viaje.CurrentCell.RowIndex].CantidadPasajeros < Compañia.viajesRegionales[dataGridView_viaje.CurrentCell.RowIndex].Embarcacion.CapacidadPasajeros)
                    {
                        if(Compañia.viajesRegionales[dataGridView_viaje.CurrentCell.RowIndex].AgregarPasajero(pasajero))
                        {
                            MessageBox.Show("Agregado exitosamente", "se pudo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    if (Compañia.viajesExtraRegionales[dataGridView_viaje.CurrentCell.RowIndex].CantidadPasajeros < Compañia.viajesExtraRegionales[dataGridView_viaje.CurrentCell.RowIndex].Embarcacion.CapacidadPasajeros)
                    {
                        if (Compañia.viajesExtraRegionales[dataGridView_viaje.CurrentCell.RowIndex].AgregarPasajero(pasajero))
                        {
                            MessageBox.Show("Agregado exitosamente", "se pudo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

            }
        }
    }
}
