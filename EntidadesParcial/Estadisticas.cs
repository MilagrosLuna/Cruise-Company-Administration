using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Estadisticas
    {
        public static List<Pasajero> listaPasajeros;
        public static List<ViajeExtraRegionales> viajesExtraRegionales;
        public static List<ViajeRegionales> viajesRegionales;
        public static float recaudacionTotal;

        public static Regionales destinoRegional;
        public static ExtraRegionales destinoExtraRegional;

        static Estadisticas()
        {
            viajesRegionales = Compañia.viajesRegionales;
            viajesExtraRegionales = Compañia.viajesExtraRegionales;

            listaPasajeros = new List<Pasajero>();
            foreach (ViajeRegionales item in Estadisticas.viajesRegionales)
            {
                foreach (Pasajero pasajero in item.ListaPasajeros)
                {
                    listaPasajeros.Add(pasajero);
                }
            }

            foreach (ViajeExtraRegionales item in Estadisticas.viajesExtraRegionales)
            {
                foreach (Pasajero pasajero in item.ListaPasajeros)
                {
                    listaPasajeros.Add(pasajero);
                }
            }


        }


    }
}
