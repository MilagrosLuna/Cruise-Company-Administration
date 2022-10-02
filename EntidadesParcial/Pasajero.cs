using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Equipajes con los que viaja (puede ser de mano y/o de bodega).

namespace EntidadesParcial
{
    public class Pasajero
    {

        private List<Bolsos> equipajes;  // clase Bolsos
        private TipoPasajero clase;
        private Cliente cliente;

        #region propiedades
        public TipoPasajero Clase
        {
            get { return clase; }
        }

        public string Cliente
        {
            get
            {
               return cliente.ToString();
            }
        }
        public string Apellido
        {
            get { return cliente.Apellido; }
        }

        public int NumeroDelPasaporte
        {
            get { return cliente.NumeroDelPasaporte; }
        }
        public int Edad
        {
            get { return cliente.Edad; }
        }
        public string Nombre
        {
            get { return cliente.Nombre; }
        }
        public string Equipaje
        {
            get 
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendLine($"El equipaje es: ");
                foreach (Bolsos item in this.equipajes)
                {
                    cadena.AppendLine($"- {item.ToString()} ");
                }
                return cadena.ToString();
            }
        }



        public List<Bolsos> Equipajes
        {
            get { return equipajes; }
        }

        #endregion

        /// <summary>
        /// constructor base del pasajero
        /// </summary>
        private Pasajero()
        {
            this.equipajes = new List<Bolsos>();
            this.clase = TipoPasajero.NoCargado;
            Pasaporte p1 = new Pasaporte(DateTime.Today, 0, Nacionalidad.NoCargado);
            this.cliente = new Cliente("", "", p1, 0, Sexo.NoCargado);

        }
        /// <summary>
        /// constructor parametrizado
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="clase"></param>
        public Pasajero(Cliente cliente, TipoPasajero clase) : this()
        {
            this.clase = clase;
            this.cliente = cliente;
            this.cliente.EnViaje = true;
        }
        
        /// <summary>
        /// sobrecarga del operador +, que permite agregar un bolso a la lista de bolsos q tiene el pasajero
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="bolso"></param>
        /// <returns></returns>
        public static Pasajero operator +(Pasajero pasajero, Bolsos bolso)
        {
            if(bolso is not null && pasajero is not null)
            {
                pasajero.equipajes.Add(bolso);
            }
            return pasajero;
        }


        /// <summary>
        /// mostrar informacion del pasajero
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Pasajero: ");
            cadena.AppendLine($"El cliente es: {this.cliente.ToString()} ");

            cadena.AppendLine($"El equipaje es: ");
            foreach (Bolsos item in this.equipajes)
            {
                cadena.AppendLine($"- {item.ToString()} ");  
            }

            cadena.AppendLine($"La clase es: {this.clase} ");

            

            return cadena.ToString();
        }
        /// <summary>
        /// sobrecarga del to string mostrando informacion del pasajero
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// sobrecarga del == para comparar 2 pasajeros, compara por numero de pasaporte
        /// </summary>
        /// <param name="pasajero1"></param>
        /// <param name="pasajero2"></param>
        /// <returns></returns>
        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            bool rta = false;
            if(pasajero1 is not null && pasajero2 is not null)
            {
                if (pasajero1.cliente.NumeroDelPasaporte == pasajero2.cliente.NumeroDelPasaporte)
            {
                rta = true;
            }
            }
            return rta;
        }
        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2)
        {
            return !(pasajero1 == pasajero2);
        }
        /// <summary>
        /// sobrecarga del equals para q compare en base a lo q yo quiero, uso el == por pasaporte
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool ok = false;
            if (obj is Pasajero)
            {
                if (this == ((Pasajero)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.cliente.NumeroDelPasaporte.GetHashCode();
        }







    }
}
