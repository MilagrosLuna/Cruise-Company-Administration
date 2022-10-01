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
    public partial class FrmVentaPasaje : Form
    {
        protected int banderaValija;
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }
       

        protected bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("nombre");
            }

            if (string.IsNullOrWhiteSpace(textBox_apellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("apellido");
            }
            
            if(int.TryParse(textBox3_edad.Text , out int edad)==false)
            {
                esValido = false;
                stringBuilder.AppendLine("edad");
            }

            if (int.TryParse(textBox_numPasaporte.Text, out int pas)==false)
            {
                esValido = false;
                stringBuilder.AppendLine("numero pasaporte");
            }

            if(radioButton_NoBolso.Checked==false&&radioButton_siBolso.Checked==false)
            {
                esValido = false;
                stringBuilder.AppendLine("bolso de mano");
            }

            if(banderaValija==0)
            {
                esValido = false;
                stringBuilder.AppendLine("valija");
            }
            

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void button_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ingrese los datos del pasajero \n agregue como minimo una valija\n cree el pasajero con el boton", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
