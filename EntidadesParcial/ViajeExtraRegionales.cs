﻿using System;
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
                this.precioPremiumBruto = precioPremium * this.duracionHoras;
                this.precioTuristaBruto = precioTurista * this.duracionHoras;

                this.precioPremium = precioPremiumBruto + (precioPremiumBruto * 21 / 100);
                this.precioTurista = precioTuristaBruto + (precioTuristaBruto * 21 / 100);
            }
        }

       
        #region propiedades
        public DateTime LLegada
        {
            get { return fechaInicio.AddHours(this.duracionHoras); }
        }

        public ExtraRegionales DestinoExtraRegional
        {
            get { return destinoExtraRegional; }
        }
        #endregion


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

        /// <summary>
        /// sobrecarga del == compara en base a la fecha de inicio y el destino
        /// </summary>
        /// <param name="viaje1"></param>
        /// <param name="viaje2"></param>
        /// <returns></returns>
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
