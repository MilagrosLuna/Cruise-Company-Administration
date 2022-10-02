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

        /// <summary>
        ///  constructor parametrizado de cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="pasaporte"></param>
        /// <param name="edad"></param>
        /// <param name="genero"></param>
        public Cliente(string nombre, string apellido, Pasaporte pasaporte, int edad, Sexo genero) : base(nombre, apellido, edad, genero)
        {
            if (pasaporte is not null)
            {
                this.pasaporteP = pasaporte;
                this.enViaje = false;
            }
        }
        #region propiedades
        public override string NombreCompeto
        {
            get { return this.nombre + " " + this.apellido; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }

        public int NumeroDelPasaporte
        {
            get { return this.pasaporteP.NumeroPasaporte ; }
        }
        public int Edad
        {
            get { return this.edad; }
        }

        public bool EnViaje
        {
            set { enViaje = value; }
        }
        #endregion

        /// <summary>
        /// metodo para mostrar datos de los clientes
        /// </summary>
        /// <returns></returns> cadena con la informacion
        private string MostrarCliente()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($" {this.pasaporteP.ToString()} ");

            return cadena.ToString();
        }
        /// <summary>
        /// sobrecarga del to string para cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarCliente();
        }
    }
}
