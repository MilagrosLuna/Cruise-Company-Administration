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
    

        public int NumeroPasaporte
        {
            get { return this.numeroPasaporte; }
        }

        private Pasaporte()
        {
            this.fechaExp = DateTime.Today;
            this.numeroPasaporte = 0;
            this.nacionalidad = Nacionalidad.NoCargado;
        }
        public Pasaporte(DateTime fecha,int numero, Nacionalidad nacionalidad):this()
        {
            if( numero>0 )
            {
                this.fechaExp = fecha;
                this.numeroPasaporte = numero;
                this.nacionalidad = nacionalidad;
            }
        }

        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Pasaporte: ");
            cadena.AppendLine($"El numero de pasaporte es: {this.numeroPasaporte} ");
            cadena.AppendLine($"La fecha de expiracion del pasaporte es: {this.fechaExp.ToString()} ");
            cadena.AppendLine($"La nacionalidad es: {this.nacionalidad} ");
            return cadena.ToString();
        }
       
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
