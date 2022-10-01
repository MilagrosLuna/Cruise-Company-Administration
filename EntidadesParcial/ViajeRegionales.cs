using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class ViajeRegionales : Viaje
    {
        private Regionales destinoRegional;
     
        public ViajeRegionales(Regionales destino,DateTime fecha, Crucero c1, int camarotesPremium, int camarotesTurista, float precioPremium, float precioTurista) : base(fecha, c1, camarotesPremium, camarotesTurista)
        {
            if (precioPremium > 0 && precioTurista > 0)
            {
                this.destinoRegional = destino;
                Random myObject = new Random();
                this.duracionHoras = myObject.Next(72, 360);
                this.precioPremium = precioPremium * this.duracionHoras;
                this.precioTurista = precioTurista * this.duracionHoras;
            }
        }

        #region propiedades
        public DateTime LLegada
        {
            get { return fechaInicio.AddHours(this.duracionHoras); }
        }

        public Regionales DestinoRegional
        {
            get { return destinoRegional; }
        }
        #endregion

        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine($"El destino es: {this.destinoRegional} ");

            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// sobrecarga del == compara por fecha y por destino
        /// </summary>
        /// <param name="viaje1"></param>
        /// <param name="viaje2"></param>
        /// <returns></returns>
        public static bool operator ==(ViajeRegionales viaje1, ViajeRegionales viaje2)
        {
            bool rta = false;
            if(viaje1.fechaInicio==viaje2.fechaInicio && viaje1.destinoRegional == viaje2.destinoRegional)
            {
                rta = true;
            }
            return rta;
        }
        public static bool operator !=(ViajeRegionales viaje1, ViajeRegionales viaje2)
        {
            return !(viaje1 == viaje2);
        }

        public override bool Equals(object obj)
        {
            bool ok = false;
            if (obj is ViajeRegionales)
            {
                if (this == ((ViajeRegionales)obj))
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
