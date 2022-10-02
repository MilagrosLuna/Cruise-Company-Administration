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
    public partial class FrmAgregaCrucero : Form
    {
        public FrmAgregaCrucero()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Compañia.embarcaciones;
        }

        private void button_agregarCrucero_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                string matricula = this.textBoxmatricula.Text;
                string nombre = this.textBoxnombre.Text;

                int camarotes = (int)this.numericUpDown_camarotes.Value;
                int salones = (int)this.numericUpDown_salones.Value;
                int casinos = (int)this.numericUpDown_casinos.Value;

                ESiNo pileta = ESiNo.No;
                ESiNo gimnasio = ESiNo.No;
                ESiNo bares = ESiNo.No;
                ESiNo videojuegos = ESiNo.No;
                if (checkedListBox_extrasCrucero.GetItemChecked(0))
                {
                    pileta = ESiNo.Si;
                }
                if (checkedListBox_extrasCrucero.GetItemChecked(1))
                {
                    gimnasio = ESiNo.Si;
                }
                if (checkedListBox_extrasCrucero.GetItemChecked(2))
                {
                    bares = ESiNo.Si;
                }
                if (checkedListBox_extrasCrucero.GetItemChecked(3))
                {
                    videojuegos = ESiNo.Si;
                }
                Crucero nuevaEmbarcacion = new Crucero(matricula, nombre, salones, casinos, camarotes, pileta, gimnasio, bares, videojuegos);
                if(Compañia.AgregarEmbarcacion(nuevaEmbarcacion))
                {
                    MessageBox.Show("Agregado exitosamente", "se pudo!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = Compañia.embarcaciones;
                }
                else
                {
                    MessageBox.Show("no se pudo agregar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }


        protected bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(textBoxmatricula.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("matricula");
            }

            if (string.IsNullOrWhiteSpace(textBoxnombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("nombre");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void button_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ingrese los datos del crucero y seleccione crear", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
