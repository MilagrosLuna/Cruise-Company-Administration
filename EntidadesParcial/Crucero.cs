using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Crucero
    {
        private string matricula;//(un identificador alfanumérico de 8 dígitos).
        private string nombre;
        private List<Camarote> Camarotes;// (con capacidad para 4 personas cada uno).
        private int cantidadSalones;//(al menos uno, el salón comedor).
        private int cantidadCasinos;//(puede no tener).
        private static int capacidadBodega;//(en kilogramos).
        private int cantidadCamarotes;
        private int capacidadBodegaActual;
        private int capacidadPasajerosActual;
        private bool enViaje;
        private ESiNo pileta;
        private ESiNo gimnasio;
        private ESiNo bares;
        private ESiNo videoJuegos;

        static Crucero()
        {
            Crucero.capacidadBodega = 10000;
        }

        #region propiedades
        public int CapacidadBodegaActual
        {
            get { return this.capacidadBodegaActual; }
            set { this.capacidadBodegaActual = value; }
        }

        public int CapacidadPasajeros
        {
            get { return this.cantidadCamarotes*Camarote.Capacidad; }
        }
        public int CapacidadPasajerosActual
        {
            get { return this.capacidadPasajerosActual; }
            set { this.capacidadPasajerosActual = value; }
        }

        public bool EnViaje
        {
            get { return this.enViaje; }
            set { this.enViaje = value; }
        }

        public int CapacidadBodega
        {
            get { return capacidadBodega; }
        }

        public int CamarotesCantidad
        {
            get { return cantidadCamarotes; }
        }
        #endregion

        /// <summary>
        /// constructor base del crucero
        /// </summary>
        /// <param name="cantidadCamarotes"></param>
        private Crucero(int cantidadCamarotes)
        {
            if(cantidadCamarotes>0)
            {
                this.enViaje = false;
                this.pileta = ESiNo.No;
                this.gimnasio = ESiNo.No;
                this.bares = ESiNo.No;
                this.videoJuegos = ESiNo.No;
                this.capacidadBodegaActual = Crucero.capacidadBodega;
                this.matricula = "";
                this.nombre = "";
                // this.cantidadCamarotes = cantidadCamarotes;
                this.Camarotes = new List<Camarote>();
                for (int i = 0; i < cantidadCamarotes; i++)
                {
                    Camarote c1 = new Camarote();
                    this.Camarotes.Add(c1);
                }
                this.cantidadSalones = 1;
                this.cantidadCasinos = 0;
                this.cantidadCamarotes = this.Camarotes.Count;
                this.capacidadPasajerosActual = this.CapacidadPasajeros;
            }
        }
        /// <summary>
        /// constructor parametrizado de crucero
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="nombre"></param>
        /// <param name="salones"></param>
        /// <param name="casinos"></param>
        /// <param name="camarotes"></param>
        /// <param name="pileta"></param>
        /// <param name="gimnasio"></param>
        /// <param name="bares"></param>
        /// <param name="videoJuegos"></param>
        public Crucero(string matricula, string nombre, int salones, int casinos,int camarotes, ESiNo pileta, ESiNo gimnasio, ESiNo bares, ESiNo videoJuegos) :this(camarotes)
        {
            if(matricula is not null && nombre is not null&& salones>0 && casinos>-1)
            {
                this.matricula = matricula;
                this.nombre = nombre;
                this.cantidadSalones = salones;
                this.cantidadCasinos = casinos;
                this.pileta = pileta;
                this.gimnasio = gimnasio;
                this.bares = bares;
                this.videoJuegos = videoJuegos;
            }
        }
        /// <summary>
        /// crea la cadena con informacion del crucero
        /// </summary>
        /// <returns></returns> cadena con la info
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Datos Crucero: ");
            cadena.Append($"Esta en viaje? ");
            if (this.enViaje)
            {
                cadena.AppendLine("si ");
            }
            else
            {
                cadena.AppendLine("no ");
            }
            cadena.AppendLine($"La matricula es: {this.matricula} ");
            cadena.AppendLine($"El nombre es: {this.nombre} ");
            cadena.AppendLine($"Camarotes: {this.Camarotes.Count} "); 
            cadena.AppendLine($"La cantidad de salones es: {this.cantidadSalones} ");
            cadena.AppendLine($"La cantidad de casinos es: {this.cantidadCasinos} ");
            cadena.AppendLine($"La capacidad total de la bodega es de: {this.CapacidadBodega} kg ");
            cadena.AppendLine($"La capacidad restante de la bodega es de: {this.CapacidadBodegaActual} kg ");
            cadena.AppendLine($"Ofrece pileta: {this.pileta} ");
            cadena.AppendLine($"Ofrece gimnasio:{this.gimnasio} ");
            cadena.AppendLine($"Ofrece bares: {this.bares} ");
            cadena.AppendLine($"Ofrece videoJuegos: {this.videoJuegos} ");
            return cadena.ToString();
        }
        /// <summary>
        /// sobrecarga del toString para crucero
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
