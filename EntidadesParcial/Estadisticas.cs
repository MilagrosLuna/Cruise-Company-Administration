using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Estadisticas
    {
        public static List<ViajeExtraRegionales> viajesExtraRegionalesEstadistica;
        public static List<ViajeRegionales> viajesRegionalesEstadistica;

        public static List<Destinos> destinos;


        private static float precioTuristaRegional = 57;
        private static float precioPremiumRegional = precioTuristaRegional + (precioTuristaRegional * 20 / 100);
        private static float precioTuristaExtraRegional = 120;
        private static float precioPremiumExtraRegional = precioTuristaExtraRegional + (precioTuristaExtraRegional * 20 / 100);

        public static Regionales destinoRegional;
        public static ExtraRegionales destinoExtraRegional;

        static Estadisticas()
        {
            Estadisticas.viajesRegionalesEstadistica = new List<ViajeRegionales>();
            Estadisticas.viajesExtraRegionalesEstadistica = new List<ViajeExtraRegionales>();

            Estadisticas.destinos = new List<Destinos>();

            #region cargar destinos
            foreach (var item in Enum.GetValues(typeof(Regionales)))
            {
                string cadena = item.ToString();
                Destinos destino = new Destinos(cadena, 0, 0, 0);
                Estadisticas.destinos.Add(destino);
            }
            foreach (var item in Enum.GetValues(typeof(ExtraRegionales)))
            {
                string cadena = item.ToString();
                Destinos destino = new Destinos(cadena, 0, 0, 0);
                Estadisticas.destinos.Add(destino);
            }

           

            #endregion

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


            foreach (var item in Estadisticas.harcodear(136, "diego", "busi"))
            {
                viajeRegional01.AgregarPasajero(item);
            }

            DateTime fecha1 = new DateTime(2018, 9, 29, 15, 26, 0);
            camarotesPremiun = embarcacion8.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion8.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional1 = new ViajeRegionales(Regionales.Cartagena_Colombia, fecha1, embarcacion8, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion8.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(400, "mario", "luna"))
            {
                viajeRegional1.AgregarPasajero(item);
            }


            DateTime fecha2 = new DateTime(2020, 8, 18, 20, 0, 0);
            camarotesPremiun = embarcacion2.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion2.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional2 = new ViajeRegionales(Regionales.Recife_Brasil, fecha2, embarcacion2, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion2.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(36, "felipe", "iglesias"))
            {
                viajeRegional2.AgregarPasajero(item);
            }


            DateTime fecha3 = new DateTime(2019, 9, 30, 5, 56, 0);
            camarotesPremiun = embarcacion3.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion3.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional3 = new ViajeRegionales(Regionales.Santiago_Chile, fecha3, embarcacion3, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion3.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(199, "nancy", "iris"))
            {
                viajeRegional3.AgregarPasajero(item);
            }


            Estadisticas.viajesRegionalesEstadistica.Add(viajeRegional01);
            Estadisticas.viajesRegionalesEstadistica.Add(viajeRegional1);
            Estadisticas.viajesRegionalesEstadistica.Add(viajeRegional2);
            Estadisticas.viajesRegionalesEstadistica.Add(viajeRegional3);



            DateTime fecha4 = new DateTime(2019, 9, 30, 9, 36, 0);
            camarotesPremiun = embarcacion4.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion4.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional1 = new ViajeExtraRegionales(ExtraRegionales.Acapulco_México, fecha4, embarcacion4, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion4.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(200, "juanse", "calles"))
            {
                viajeExtraRegional1.AgregarPasajero(item);
            }


            DateTime fecha5 = new DateTime(2021, 7, 10, 3, 36, 0);
            camarotesPremiun = embarcacion5.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion5.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional2 = new ViajeExtraRegionales(ExtraRegionales.Atenas_Grecia, fecha5, embarcacion5, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion5.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(600, "joaquin", "roca"))
            {
                viajeExtraRegional2.AgregarPasajero(item);
            }

            DateTime fecha6 = new DateTime(2021, 10, 2, 8, 36, 0);
            camarotesPremiun = embarcacion7.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion7.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional3 = new ViajeExtraRegionales(ExtraRegionales.Venecia_Italia, fecha6, embarcacion7, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion7.EnViaje = false;
            foreach (var item in Estadisticas.harcodear(183, "adrian", "sales"))
            {
                viajeExtraRegional3.AgregarPasajero(item);
            }

            DateTime fecha7 = new DateTime(2018, 10, 1, 14, 44, 0);
            camarotesPremiun = embarcacion8.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion8.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional4 = new ViajeExtraRegionales(ExtraRegionales.Bangkok_Tailandia, fecha7, embarcacion8, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion8.EnViaje = false;

            foreach (var item in Estadisticas.harcodear(200, "manuel", "sanchez"))
            {
                viajeExtraRegional4.AgregarPasajero(item);
            }

            Estadisticas.viajesExtraRegionalesEstadistica.Add(viajeExtraRegional1);
            Estadisticas.viajesExtraRegionalesEstadistica.Add(viajeExtraRegional2);
            Estadisticas.viajesExtraRegionalesEstadistica.Add(viajeExtraRegional3);
            Estadisticas.viajesExtraRegionalesEstadistica.Add(viajeExtraRegional4);



            #endregion


            foreach (var item in Estadisticas.viajesRegionalesEstadistica)
            {
                for (int i = 0; i < Estadisticas.destinos.Count; i++)
                {
                    if (item.DestinoRegional.ToString() == Estadisticas.destinos[i].Destino)
                    {
                        Estadisticas.destinos[i].CantidadViajes++;
                        Estadisticas.destinos[i].CantidadPasajeros += item.CantidadPasajeros;
                        foreach (Pasajero pasajero in item.ListaPasajeros)
                        {
                            if (pasajero.Clase == TipoPasajero.Premium)
                            {
                                Estadisticas.destinos[i].Recaudacion += item.PrecioPremium;
                            }
                            else
                            {
                                Estadisticas.destinos[i].Recaudacion += item.PrecioTurista;
                            }
                        }
                    }
                }
            }

            foreach (var item in Estadisticas.viajesExtraRegionalesEstadistica)
            {
                for (int i = 0; i < Estadisticas.destinos.Count; i++)
                {
                    if (item.DestinoExtraRegional.ToString() == Estadisticas.destinos[i].Destino)
                    {
                        Estadisticas.destinos[i].CantidadViajes++;
                        Estadisticas.destinos[i].CantidadPasajeros += item.CantidadPasajeros;
                        foreach (Pasajero pasajero in item.ListaPasajeros)
                        {
                            if (pasajero.Clase == TipoPasajero.Premium)
                            {
                                Estadisticas.destinos[i].Recaudacion += item.PrecioPremium;
                            }
                            else
                            {
                                Estadisticas.destinos[i].Recaudacion += item.PrecioTurista;
                            }
                        }
                    }
                }
            }

            

        }

       

        /// <summary>
        /// metodo para harcodear pasajeros en un viaje 
        /// </summary>
        /// <param name="cantidad"></param>  recibe la cantidad de pasajeros a harcodear
        /// <returns></returns> devuelve una lista de pasajeros
        public static List<Pasajero> harcodear(int cantidad, string nombre, string apellido)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            Pasajero pasajero;
            for (int i = 0; i < cantidad; i++)
            {
                int numPasaporte = 23 + i;
                Nacionalidad nacionalidad = Nacionalidad.AntiguaYBarbuda;
                Pasaporte pasaporte = new Pasaporte(DateTime.Today, numPasaporte, nacionalidad);
                int edad = 21;
                Sexo genero = Sexo.Hombre;
                Cliente cliente = new Cliente(nombre, apellido, pasaporte, edad, genero);
                TipoPasajero tipoPasajero = TipoPasajero.Premium;

                pasajero = new Pasajero(cliente, tipoPasajero);
                Bolsos valija = new Bolsos(6, Equipaje.De_Bodega);
                pasajero = pasajero + valija;

                pasajeros.Add(pasajero);
            }
            return pasajeros;
        }


    }
}
