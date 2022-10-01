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
    public partial class FrmCreaViaje : Form
    {
        private int bandera = 0;
        public FrmCreaViaje()
        {
            InitializeComponent();
            this.comboBox_Embarcaciones.DataSource = Compañia.embarcaciones;
        }

        private void button_verDestinos_Click(object sender, EventArgs e)
        {
            bandera = 1;
            if (radioButton_extraRegional.Checked)
            {
                List<string> extra = new List<string>(Enum.GetNames(typeof(ExtraRegionales)).ToArray());
                comboBox_seleccionarDestino.DataSource = extra;
            }
            if(radioButton_regional.Checked)
            {
                List<string> regionales = new List<string>(Enum.GetNames(typeof(Regionales)).ToArray());
                comboBox_seleccionarDestino.DataSource = regionales;
            }
        }

        private void button_crearViaje_Click(object sender, EventArgs e)
        {
            if(this.bandera==1)
            {
                DateTime fecha = dateTimePicker_Partida.Value;
                Crucero embarcacion = (Crucero)comboBox_Embarcaciones.SelectedItem;
                int camarotesPremiun = embarcacion.CamarotesCantidad * 35 / 100;
                int camarotesTurista = embarcacion.CamarotesCantidad - camarotesPremiun;
                fecha.ToShortDateString();
                if(embarcacion.EnViaje==false&&embarcacion.CapacidadBodega>embarcacion.CapacidadBodegaActual)
                {
                    if (radioButton_extraRegional.Checked)
                    {
                        ExtraRegionales destinoER = (ExtraRegionales)comboBox_seleccionarDestino.SelectedIndex;

                        ViajeExtraRegionales viajeER = new ViajeExtraRegionales(destinoER, fecha, embarcacion, camarotesPremiun, camarotesTurista, Compañia.PrecioPremiumExtraRegional, Compañia.PrecioTuristaExtraRegional);
                        if (Compañia.AgregarViaje(viajeER))
                        {
                            MessageBox.Show("Agregado exitosamente", "se pudo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            viajeER.Embarcacion.EnViaje = true;
                        }
                    }
                    if (radioButton_regional.Checked)
                    {
                        Regionales destinoR = (Regionales)comboBox_seleccionarDestino.SelectedIndex;

                        ViajeRegionales viajeR = new ViajeRegionales(destinoR, fecha, embarcacion, camarotesPremiun, camarotesTurista, Compañia.PrecioPremiumRegional, Compañia.PrecioTuristaRegional);
                        if (Compañia.AgregarViaje(viajeR))
                        {
                            MessageBox.Show("Agregado exitosamente", "se pudo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            viajeR.Embarcacion.EnViaje = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El crucero no esta disponible!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un destino!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seleccione si quiere un destino regional o extra regional\n ingrese los datos y cree el viaje", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
