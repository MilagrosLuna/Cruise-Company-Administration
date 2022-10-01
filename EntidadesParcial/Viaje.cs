using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public abstract class Viaje
    {
        public enum PuertoPartida
        {
            BuenosAires_Argentina
        };

        protected PuertoPartida puerto;
        protected DateTime fechaInicio;
        protected DateTime fechaActual;
        protected Crucero embarcacion;
        protected int cantidadCamarotesPremium;
        protected int cantidadCamarotesTurista;
        protected float precioPremium;
        protected float precioTurista;
        protected int duracionHoras;
        protected List<Pasajero> pasajeros;

        public List<Pasajero> ListaPasajeros
        {
            get { return this.pasajeros; }
        }

        public int CantidadPasajeros
        {
            get { return pasajeros.Count; }
        }

        public PuertoPartida Puerto
        {
            get { return puerto; }
        }
        public String FechaDePartida
        {
            get { return fechaInicio.ToString(); }
        }
        public Crucero Embarcacion
        {
            get { return embarcacion; }
        }
        public int CantidadCamarotesPremium
        {
            get { return cantidadCamarotesPremium; }
        }
        public int CantidadCamarotesTurista
        {
            get { return cantidadCamarotesTurista; }
        }
        public float PrecioPremium
        {
            get { return precioPremium; }
        }
        public float PrecioTurista
        {
            get { return precioTurista; }
        }
        public int DuracionHoras
        {
            get { return duracionHoras; }
        }


        protected Viaje()
        {
            this.puerto = PuertoPartida.BuenosAires_Argentina;
            this.fechaInicio = DateTime.Today;
            this.embarcacion = new Crucero("","",1,0,1,ESiNo.No, ESiNo.No, ESiNo.No, ESiNo.No);
            this.cantidadCamarotesPremium = 0;
            this.cantidadCamarotesTurista = 0;
            this.precioPremium = 0;
            this.precioTurista = 0;
            this.duracionHoras = 0;
            this.pasajeros = new List<Pasajero>();
        }
        public Viaje(DateTime fecha, Crucero c1, int camarotesPremium, int camarotesTurista) : this()
        {
            if (camarotesPremium > 0 && c1 is not null && camarotesTurista>0)
            {
                this.fechaInicio = fecha;
                this.embarcacion = c1;
                this.cantidadCamarotesPremium = camarotesPremium;
                this.cantidadCamarotesTurista = camarotesTurista;
            }
        }

        public virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Viaje: ");
            cadena.AppendLine($"La fecha de inicio es: {this.fechaInicio.ToString()} ");            
            cadena.AppendLine($"{this.embarcacion.ToString()} ");
            cadena.AppendLine($"La cantidad de camarotes premium es: {this.cantidadCamarotesPremium} ");
            cadena.AppendLine($"La cantidad de camarotes turista es: {this.cantidadCamarotesTurista} ");
            cadena.AppendLine($"El precio premium es: {this.precioPremium} ");
            cadena.AppendLine($"El precio turista es: {this.precioTurista} ");
            cadena.AppendLine($"La duracion del viaje es: {this.duracionHoras} ");
            cadena.AppendLine($"El puerto de partida es: {this.puerto} ");
            return cadena.ToString();
        }

        protected bool BuscarPasajero(Pasajero pasajero)
        {
            bool rta = false;
            foreach (Pasajero aux in this.pasajeros)
            {
                if (pasajero == aux)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }


        /// <summary>
        ///  VA A VERIFICAR QUE EL PASAJERO NO ESTE EN LA LISTA Y LO VA A AGREGAR
        /// </summary>
        /// <param name="pasajero"></param> recibe pasajero para agregar
        /// <param name="lista"></param> recibe un int para ver en que lista lo agrega si en regional(1) o extraregiona(2)
        /// <returns></returns>
        public bool AgregarPasajero(Pasajero pasajero)
        {
            bool ok = false;
            if (BuscarPasajero(pasajero) == false)
            {
                this.pasajeros.Add(pasajero);
                foreach (Bolsos item in pasajero.Equipajes)
                {
                    this.embarcacion.CapacidadBodegaActual -= item.Peso;
                }
            }
            return ok;
        }

    }
}
