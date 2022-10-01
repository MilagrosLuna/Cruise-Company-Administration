using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected Sexo genero;

        private Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.genero = Sexo.NoCargado;
        }

        public abstract string NombreCompeto
        {
            get;
        }

        protected Persona(string nombre,string apellido,int edad, Sexo genero) : this()
        {
            if(nombre is not null && apellido is not null && edad>0 && genero != Sexo.NoCargado)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.genero = genero;
            }    
        }
        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"El apellido es: {this.apellido} ");
            cadena.AppendLine($"El genero es: {this.genero} ");
            cadena.AppendLine($"La edad es: {this.edad} ");
            return cadena.ToString();
        }
    }
}
