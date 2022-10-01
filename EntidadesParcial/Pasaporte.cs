using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Pasaporte
    {
        
        private DateTime fechaExp;
        private int numeroPasaporte;
        private Nacionalidad nacionalidad;
    
        #region propiedades
        public int NumeroPasaporte
        {
            get { return this.numeroPasaporte; }
        }
        #endregion
        /// <summary>
        /// constructor base pasaporte
        /// </summary>
        private Pasaporte()
        {
            this.fechaExp = DateTime.Today;
            this.numeroPasaporte = 0;
            this.nacionalidad = Nacionalidad.NoCargado;
        }
        /// <summary>
        /// constructor parametrizado de pasporte
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="numero"></param>
        /// <param name="nacionalidad"></param>
        public Pasaporte(DateTime fecha,int numero, Nacionalidad nacionalidad):this()
        {
            if( numero>0 && nacionalidad!= Nacionalidad.NoCargado)
            {
                this.fechaExp = fecha;
                this.numeroPasaporte = numero;
                this.nacionalidad = nacionalidad;
            }
        }
        /// <summary>
        /// muestra informacion del pasaporte
        /// </summary>
        /// <returns></returns> cadena con la informacion
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Pasaporte: ");
            cadena.AppendLine($"El numero de pasaporte es: {this.numeroPasaporte} ");
            cadena.AppendLine($"La fecha de expiracion del pasaporte es: {this.fechaExp.ToString()} ");
            cadena.AppendLine($"La nacionalidad es: {this.nacionalidad} ");
            return cadena.ToString();
        }
       /// <summary>
       /// convierte el pasaporte a string con los datos q contiene(uso el mostrar)
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
