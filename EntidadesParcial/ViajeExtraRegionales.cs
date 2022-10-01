using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class ViajeExtraRegionales : Viaje
    {
        private ExtraRegionales destinoExtraRegional;
       
        public ViajeExtraRegionales(ExtraRegionales destino, DateTime fecha, Crucero c1, int camarotesPremium, int camarotesTurista, float precioPremium, float precioTurista) : base(fecha, c1, camarotesPremium, camarotesTurista)
        {
            if(precioPremium > 0 && precioTurista > 0)
            {
                this.destinoExtraRegional = destino;
                Random myObject = new Random();
                this.duracionHoras = myObject.Next(480, 720);
                this.precioPremium = precioPremium * this.duracionHoras;
                this.precioTurista = precioTurista * this.duracionHoras;
            }
        }

       

        public DateTime LLegada
        {
            get { return fechaInicio.AddHours(this.duracionHoras); }
        }

        public ExtraRegionales DestinoExtraRegional
        {
            get { return destinoExtraRegional; }
        }


        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($"El destino es: {this.destinoExtraRegional} ");
            
            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }


        public static bool operator ==(ViajeExtraRegionales viaje1, ViajeExtraRegionales viaje2)
        {
            bool rta = false;
            if (viaje1.fechaInicio == viaje2.fechaInicio && viaje1.destinoExtraRegional == viaje2.destinoExtraRegional)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(ViajeExtraRegionales viaje1, ViajeExtraRegionales viaje2)
        {
            return !(viaje1 == viaje2);
        }

        public override bool Equals(object obj)
        {
            bool ok = false;
            if (obj is ViajeExtraRegionales)
            {
                if (this == ((ViajeExtraRegionales)obj))
                {
                    ok = true;
                }
            }
            return ok;
        }

        public override int GetHashCode()
        {
            return this.embarcacion.GetHashCode();
        }


      

        

    }
}
