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


        private Pasajero()
        {
            this.equipajes = new List<Bolsos>();
            this.clase = TipoPasajero.NoCargado;
            Pasaporte p1 = new Pasaporte(DateTime.Today, 0, Nacionalidad.NoCargado);
            this.cliente = new Cliente("", "", p1, 0, Sexo.NoCargado);

        }
        public Pasajero(Cliente cliente, TipoPasajero clase) : this()
        {
            this.clase = clase;
            this.cliente = cliente;
            this.cliente.EnViaje = true;
        }
        

        public static Pasajero operator +(Pasajero pasajero, Bolsos bolso)
        {
            if(bolso is not null && pasajero is not null)
            {
                pasajero.equipajes.Add(bolso);
            }
            return pasajero;
        }



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
    
        public override string ToString()
        {
            return this.Mostrar();
        }




        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            bool rta = false;
            if (pasajero1.cliente.NumeroDelPasaporte==pasajero2.cliente.NumeroDelPasaporte)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2)
        {
            return !(pasajero1 == pasajero2);
        }

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
