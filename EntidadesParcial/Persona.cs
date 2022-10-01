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
        /// <summary>
        /// constructor base de persona
        /// </summary>
        private Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.genero = Sexo.NoCargado;
        }
        /// <summary>
        /// propiedad abstracta, user y cliente muestran distintas cosas en nombre completo
        /// </summary>
        public abstract string NombreCompeto
        {
            get;
        }
        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="genero"></param>
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
        /// <summary>
        /// mostrar datos basicos de persona
        /// </summary>
        /// <returns></returns>
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
