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

        private static float precioTuristaRegional = 57;
        private static float precioPremiumRegional = precioTuristaRegional + (precioTuristaRegional * 20 / 100);
        private static float precioTuristaExtraRegional = 120;
        private static float precioPremiumExtraRegional = precioTuristaExtraRegional + (precioTuristaExtraRegional * 20 / 100);

        public static Regionales destinoRegional;
        public static ExtraRegionales destinoExtraRegional;

        static Estadisticas()
        {
            // le asigno los viajes actules a estadisticas 
            viajesRegionales = Compañia.viajesRegionales;
            viajesExtraRegionales = Compañia.viajesExtraRegionales;

            listaPasajeros = new List<Pasajero>();

            // ademas creo viajes antiguos para harcodear informacion de las estadisticas

            #region crear y agregar cruceros
            Crucero embarcacion1 = new Crucero("vv456hh", "marquito", 15, 3, 50, ESiNo.Si, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion2 = new Crucero("yy445ff", "Las viejas", 20, 5, 100, ESiNo.Si, ESiNo.Si, ESiNo.No, ESiNo.Si);
            Crucero embarcacion3 = new Crucero("bv256cf", "Los 7 Mares", 16, 3, 80, ESiNo.No, ESiNo.Si, ESiNo.No, ESiNo.Si);
            Crucero embarcacion4 = new Crucero("ee695cv", "Juanchuli", 20, 5, 70, ESiNo.Si, ESiNo.No, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion5 = new Crucero("aa341gh", "Simones", 30, 9, 150, ESiNo.Si, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion6 = new Crucero("ae659yu", "Friolito", 20, 2, 100, ESiNo.No, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion7 = new Crucero("ai233zz", "Merced", 23, 0, 50, ESiNo.No, ESiNo.Si, ESiNo.No, ESiNo.No);
            Crucero embarcacion8 = new Crucero("ac918xx", "Victoria", 15, 3, 50, ESiNo.Si, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            #endregion

            #region crear y agregar Viajes


            DateTime fecha01 = new DateTime(2020, 6, 30, 20, 36, 0);
            int camarotesPremiun = embarcacion1.CamarotesCantidad * 35 / 100;
            int camarotesTurista = embarcacion1.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional01 = new ViajeRegionales(Regionales.IslaGalápagos_Ecuador, fecha01, embarcacion1, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion1.EnViaje = false;


            foreach (var item in Estadisticas.harcodear(136))
            {
                viajeRegional01.AgregarPasajero(item);
            }

            DateTime fecha1 = new DateTime(2018, 9, 29, 15, 26, 0);
            camarotesPremiun = embarcacion8.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion8.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional1 = new ViajeRegionales(Regionales.Cartagena_Colombia, fecha1, embarcacion8, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion8.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(400))
            {
                viajeRegional1.AgregarPasajero(item);
            }


            DateTime fecha2 = new DateTime(2020, 8, 18, 20, 0, 0);
            camarotesPremiun = embarcacion2.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion2.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional2 = new ViajeRegionales(Regionales.Recife_Brasil, fecha2, embarcacion2, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion2.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(36))
            {
                viajeRegional2.AgregarPasajero(item);
            }


            DateTime fecha3 = new DateTime(2019, 9, 30, 5, 56, 0);
            camarotesPremiun = embarcacion3.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion3.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional3 = new ViajeRegionales(Regionales.Santiago_Chile, fecha3, embarcacion3, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion3.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(199))
            {
                viajeRegional3.AgregarPasajero(item);
            }


            Estadisticas.viajesRegionales.Add(viajeRegional01);
            Estadisticas.viajesRegionales.Add(viajeRegional1);
            Estadisticas.viajesRegionales.Add(viajeRegional2);
            Estadisticas.viajesRegionales.Add(viajeRegional3);



            DateTime fecha4 = new DateTime(2019, 9, 30, 9, 36, 0);
            camarotesPremiun = embarcacion4.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion4.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional1 = new ViajeExtraRegionales(ExtraRegionales.Acapulco_México, fecha4, embarcacion4, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion4.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(200))
            {
                viajeExtraRegional1.AgregarPasajero(item);
            }


            DateTime fecha5 = new DateTime(2021, 7, 10, 3, 36, 0);
            camarotesPremiun = embarcacion5.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion5.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional2 = new ViajeExtraRegionales(ExtraRegionales.Atenas_Grecia, fecha5, embarcacion5, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion5.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(600))
            {
                viajeExtraRegional2.AgregarPasajero(item);
            }

            DateTime fecha6 = new DateTime(2021, 10, 2, 8, 36, 0);
            camarotesPremiun = embarcacion7.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion7.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional3 = new ViajeExtraRegionales(ExtraRegionales.Venecia_Italia, fecha6, embarcacion7, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion7.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(183))
            {
                viajeExtraRegional3.AgregarPasajero(item);
            }

            DateTime fecha7 = new DateTime(2018, 10, 1, 14, 44, 0);
            camarotesPremiun = embarcacion8.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion8.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional4 = new ViajeExtraRegionales(ExtraRegionales.Bangkok_Tailandia, fecha7, embarcacion8, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion8.EnViaje = false;

            foreach (var item in Estadisticas.harcodear(200))
            {
                viajeExtraRegional4.AgregarPasajero(item);
            }

            Estadisticas.viajesExtraRegionales.Add(viajeExtraRegional1);
            Estadisticas.viajesExtraRegionales.Add(viajeExtraRegional2);
            Estadisticas.viajesExtraRegionales.Add(viajeExtraRegional3);
            Estadisticas.viajesExtraRegionales.Add(viajeExtraRegional4);


            foreach (ViajeRegionales item in Compañia.viajesRegionales)
            {
                Estadisticas.viajesRegionales.Add(item);
            }

            foreach (ViajeExtraRegionales item in Compañia.viajesExtraRegionales)
            {
                Estadisticas.viajesExtraRegionales.Add(item);
            }

            #endregion

            #region agregar pasajeros
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
            #endregion


            }

        /// <summary>
        /// metodo para harcodear pasajeros en un viaje 
        /// </summary>
        /// <param name="cantidad"></param>  recibe la cantidad de pasajeros a harcodear
        /// <returns></returns> devuelve una lista de pasajeros
        public static List<Pasajero> harcodear(int cantidad)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            Pasajero pasajero;
            for (int i = 0; i < cantidad; i++)
            {
                string name = "juanpa" + i;
                string apellido = "merida";
                int numPasaporte = 23 + i;
                Nacionalidad nacionalidad = Nacionalidad.Afganistán;
                Pasaporte pasaporte = new Pasaporte(DateTime.Today, numPasaporte, nacionalidad);
                int edad = 21;
                Sexo genero = Sexo.Hombre;
                Cliente cliente = new Cliente(name, apellido, pasaporte, edad, genero);
                TipoPasajero tipoPasajero = TipoPasajero.Premium;

                pasajero = new Pasajero(cliente, tipoPasajero);
                Bolsos valija = new Bolsos(3, Equipaje.De_Bodega);
                pasajero = pasajero + valija;

                pasajeros.Add(pasajero);
            }
            return pasajeros;
        }



    }
}
