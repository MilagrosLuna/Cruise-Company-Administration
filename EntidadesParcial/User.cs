using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class User : Persona
    {
        private string usuario;
        private string contraseña;

        #region propiedad
        public override string NombreCompeto
        {
            get { return this.nombre + " " + this.apellido + " | es: " + this.usuario; }
        }
        #endregion
        /// <summary>
        /// constructor parametrizado basico de user
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        public User(string usuario, string contraseña):base("","",1,Sexo.NoCargado)
        {
            if (usuario is not null && contraseña is not null)
            {
                this.usuario = usuario;
                this.contraseña = contraseña;
            }
        }
        /// <summary>
        /// cosntructor parametrizado completo de user
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="genero"></param>
        public User(string usuario, string contraseña,string nombre, string apellido, int edad, Sexo genero) : base(nombre, apellido, edad, genero)
        {
            if(usuario is not null && contraseña is not null)
            {
                this.usuario = usuario;
                this.contraseña = contraseña;
            }
        }
        #region propiedades
        public string Usuario
        {
            get { return this.usuario; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        #endregion
        /// <summary>
        /// sobrecarga del == compara el usuario y la contraseña
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static bool operator ==(User t1, User t2)
        {
            bool rta = false;
            if (t1 is not null && t2 is not null)
            {
                if (t1.usuario == t2.usuario && t1.contraseña == t2.contraseña)
                {
                    rta = true;
                }
            }
            else
            {
                if (t1 is null && t2 is null)
                {
                    rta = true;
                }
            }
            return rta;
        }
        public static bool operator !=(User t1, User t2)
        {
            return !(t1 == t2);
        }

        public override bool Equals(object obj)
        {
            bool ok = false;
            if (obj is User)
            {
                if (this == ((User)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.edad.GetHashCode(); 
        }

    }
}
