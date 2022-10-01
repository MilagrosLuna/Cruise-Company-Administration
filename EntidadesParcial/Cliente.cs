using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Cliente : Persona
    {
        private Pasaporte pasaporteP;
        private bool enViaje;
        public Cliente(string nombre, string apellido, Pasaporte pasaporte, int edad, Sexo genero) : base(nombre, apellido, edad, genero)
        {
            if (pasaporte is not null)
            {
                this.pasaporteP = pasaporte;
                this.enViaje = false;
            }
        }



        public override string NombreCompeto
        {
            get { return this.nombre + " " + this.apellido; }
        }

        public int NumeroDelPasaporte
        {
            get { return this.pasaporteP.NumeroPasaporte ; }
        }

        public bool EnViaje
        {
            set { enViaje = value; }
        }


        private string MostrarCliente()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($" {this.pasaporteP.ToString()} ");

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCliente();
        }
    }
}
