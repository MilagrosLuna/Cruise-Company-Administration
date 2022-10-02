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
    public partial class FrmPasajeroFiltrado : Form
    {
        private List<Pasajero> pasajeros;
        private int busqueda;
        // filtro = 0 nombre 1 pasaporte 2 edad 3 apellido
        public FrmPasajeroFiltrado()
        {
            InitializeComponent();
            pasajeros = new List<Pasajero>();
        }

        public void CambiarBandera(int bandera)
        {
            this.busqueda = bandera;
            dataGridView1.Visible = false;
            RestablecerDatos();
            if (this.busqueda == 0)
            {
                this.label1.Text = "Nombre";
            }

            if (this.busqueda == 1)
            {
                this.label1.Text = "Pasaporte";
            }

            if (this.busqueda == 2)
            {
                this.label1.Text = "Edad";
            }

            if (this.busqueda == 3)
            {
                this.label1.Text = "Apellido";
            }
        }
        private void RestablecerDatos()
        {
            this.pasajeros.Clear();
        }
        private void ActualizarDg()
        {
            dataGridView1.DataSource = null;
            if (pasajeros.Count < 1)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = this.pasajeros;
            }
        }
        private void button_filtrar_click(object sender, EventArgs e)
        {
            
            if (this.busqueda==0||this.busqueda==3)
            {
               if( ValidarTexto())
                {
                    SaberPorQueFiltra();
                    ActualizarDg();
                }       
            }
            else
            {
                if (ValidarNumero())
                {
                    SaberPorQueFiltra();
                    ActualizarDg();
                }
            }

        }

        private void SaberPorQueFiltra()
        {
            if (this.busqueda == 0)
            {
                this.label1.Text = "Nombre";
                foreach (var item in Compañia.viajesRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        if(pasajero.Nombre == this.textBox1.Text)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
                foreach (var item in Compañia.viajesExtraRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        if (pasajero.Nombre == this.textBox1.Text)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
            }

            if (this.busqueda == 1)
            {
                this.label1.Text = "Pasaporte";
                foreach (var item in Compañia.viajesRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        int numeroDelPasaporte = int.Parse(this.textBox1.Text);
                        if (pasajero.NumeroDelPasaporte == numeroDelPasaporte)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
                foreach (var item in Compañia.viajesExtraRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        int numeroDelPasaporte = int.Parse(this.textBox1.Text);
                        if (pasajero.NumeroDelPasaporte == numeroDelPasaporte)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
            }

            if (this.busqueda == 2)
            {
                this.label1.Text = "Edad";
                foreach (var item in Compañia.viajesRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        int edad = int.Parse(this.textBox1.Text);
                        if (pasajero.Edad == edad)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
                foreach (var item in Compañia.viajesExtraRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        int edad = int.Parse(this.textBox1.Text);
                        if (pasajero.Edad == edad)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
            }

            if (this.busqueda == 3)
            {
                this.label1.Text = "Apellido";
                foreach (var item in Compañia.viajesRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        if (pasajero.Apellido == this.textBox1.Text)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
                foreach (var item in Compañia.viajesExtraRegionales)
                {
                    foreach (Pasajero pasajero in item.ListaPasajeros)
                    {
                        if (pasajero.Apellido == this.textBox1.Text)
                        {
                            this.pasajeros.Add(pasajero);
                        }
                    }
                }
            }

        }

        private bool ValidarTexto()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Ingrese DATO texto");
            if (string.IsNullOrWhiteSpace(textBox1.Text)||(textBox1.Text.Any(char.IsDigit)))
            {
                
                 esValido = false;
                
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private bool ValidarNumero()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Ingrese DATO numerico");

            if (int.TryParse(textBox1.Text, out int edad) == false)
            {
                esValido = false;
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

}
}
