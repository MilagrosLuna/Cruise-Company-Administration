using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Destinos
    {
        private string destino;
        private int cantidadViajes;
        private int cantidadPasajeros;
        private float recaudacion;

        public Destinos(string destino,int cantidadViajes,int cantidadPasajeros,float recaudacion)
        {
            this.destino = destino;
            this.cantidadViajes = cantidadViajes;
            this.cantidadPasajeros = cantidadPasajeros;
            this.recaudacion = recaudacion;
        }

        


        public string Destino
        {
            get { return this.destino; }
        }
        public int CantidadViajes
        {
            get { return this.cantidadViajes; }
            set { this.cantidadViajes = value; }
        }
        public int CantidadPasajeros
        {
            get { return this.cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }
        public float Recaudacion
        {
            get { return this.recaudacion; }
            set { this.recaudacion = value; }
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine($" destino: {  this.destino }");
            cadena.AppendLine($" cantidad viajes: {  this.cantidadViajes }");
            cadena.AppendLine($" cantidad pasajeros: {  this.cantidadPasajeros }");
            cadena.AppendLine($" recaudacion: {  this.recaudacion }");
            return cadena.ToString();
        }

    }
}
