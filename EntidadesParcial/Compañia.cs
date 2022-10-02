using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public static class Compañia
    {
        public static List<User> usuarios;


        public static List<int> listaPesosValija = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        public static List<ViajeExtraRegionales> viajesExtraRegionales;
        public static List<ViajeRegionales> viajesRegionales;
        private static float precioTuristaRegional = 57;
        private static float precioPremiumRegional = precioTuristaRegional + (precioTuristaRegional * 20 / 100);
        private static float precioTuristaExtraRegional = 120;
        private static float precioPremiumExtraRegional = precioTuristaExtraRegional + (precioTuristaExtraRegional * 20 / 100);

        //public static List<Viaje> viajes;
        public static List<Crucero> embarcaciones;

        #region propiedades 
        public static float PrecioTuristaRegional
        {
            get { return precioTuristaRegional; }
        }
        public static float PrecioPremiumRegional
        {
            get { return precioPremiumRegional; }
        }
        public static float PrecioTuristaExtraRegional
        {
            get { return precioTuristaExtraRegional; }
        }
        public static float PrecioPremiumExtraRegional
        {
            get { return precioPremiumExtraRegional; }
        }
        #endregion


        static Compañia()
        {
            Compañia.usuarios = new List<User>();

            User u1 = new User("mili890m", "seguritix", "milagros", "luna", 18, Sexo.Mujer);
            User u2 = new User("juanpedro90", "miabuelita1", "juan", "perez", 35, Sexo.NoBinario);
            User u3 = new User("martin89", "mundi2022", "martin", "sanchez", 28, Sexo.Hombre);
            User u4 = new User("vanesalopez", "coquitafria", "vanesa", "lopez", 42, Sexo.Mujer);
            User Admin = new User("admin22", "anana", "Sara", "Acero", 40, Sexo.Mujer);
            User u5 = new User("a", "a", "milagros", "luna", 18, Sexo.Mujer);

            Compañia.usuarios.Add(u1);
            Compañia.usuarios.Add(u2);
            Compañia.usuarios.Add(u3);
            Compañia.usuarios.Add(u4);
            Compañia.usuarios.Add(Admin);
            Compañia.usuarios.Add(u5);



            /// inicializo listas de clase estatica
            Compañia.viajesExtraRegionales = new List<ViajeExtraRegionales>();
            Compañia.viajesRegionales = new List<ViajeRegionales>();
            Compañia.embarcaciones = new List<Crucero>();

            #region crear y agregar cruceros
            Crucero embarcacion1 = new Crucero("ac918xx", "Victoria", 15, 3, 50, ESiNo.Si, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion2 = new Crucero("ad562ff", "Las 3 Cruces", 20, 5, 100, ESiNo.Si, ESiNo.Si, ESiNo.No, ESiNo.Si);
            Crucero embarcacion3 = new Crucero("bv256cf", "Los 7 Mares", 16, 3, 80, ESiNo.No, ESiNo.Si, ESiNo.No, ESiNo.Si);
            Crucero embarcacion4 = new Crucero("ee695cv", "Juanchuli", 20, 5, 70, ESiNo.Si, ESiNo.No, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion5 = new Crucero("aa341gh", "Simones", 30, 9, 150, ESiNo.Si, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion6 = new Crucero("ae659yu", "Friolito", 20, 2, 100, ESiNo.No, ESiNo.Si, ESiNo.Si, ESiNo.Si);
            Crucero embarcacion7 = new Crucero("ai233zz", "Merced", 23, 0, 50, ESiNo.No, ESiNo.Si, ESiNo.No, ESiNo.No);

            Compañia.embarcaciones.Add(embarcacion1);
            Compañia.embarcaciones.Add(embarcacion2);
            Compañia.embarcaciones.Add(embarcacion3);
            Compañia.embarcaciones.Add(embarcacion4);
            Compañia.embarcaciones.Add(embarcacion5);
            Compañia.embarcaciones.Add(embarcacion6);
            Compañia.embarcaciones.Add(embarcacion7);
            #endregion

            #region crear y agregar Viajes
           


            DateTime fecha01 = new DateTime(2022, 6, 30, 20, 36, 0);
            int camarotesPremiun = embarcacion1.CamarotesCantidad * 35 / 100;
            int camarotesTurista = embarcacion1.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional01 = new ViajeRegionales(Regionales.Cartagena_Colombia, fecha01, embarcacion1, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion1.EnViaje = false;

            Compañia.viajesRegionales.Add(viajeRegional01);

            foreach (var item in Compañia.harcodearP(166,"milagros","luna"))
            {
                viajeRegional01.AgregarPasajero(item);
            }



            DateTime fecha1 = new DateTime(2022, 9, 29, 15, 26, 0);
            camarotesPremiun = embarcacion1.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion1.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional1 = new ViajeRegionales(Regionales.Cartagena_Colombia, fecha1, embarcacion1, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion1.EnViaje = true;
            foreach (var item in Compañia.harcodearP(400,"lina","dalma"))
            {
                viajeRegional1.AgregarPasajero(item);
            }


            DateTime fecha2 = new DateTime(2022, 8, 18, 20, 0, 0);
            camarotesPremiun = embarcacion2.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion2.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional2 = new ViajeRegionales(Regionales.Recife_Brasil, fecha2, embarcacion2, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion2.EnViaje = false;
            foreach (var item in Compañia.harcodearP(36,"ian","kukil"))
            {
                viajeRegional2.AgregarPasajero(item);
            }


            DateTime fecha3 = new DateTime(2022, 9, 30, 5, 56, 0);
            camarotesPremiun = embarcacion3.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion3.CamarotesCantidad - camarotesPremiun;
            ViajeRegionales viajeRegional3 = new ViajeRegionales(Regionales.Santiago_Chile, fecha3, embarcacion3, camarotesPremiun, camarotesTurista, precioPremiumRegional, precioTuristaRegional);
            embarcacion3.EnViaje = true;
            foreach (var item in Compañia.harcodearP(199,"paula","hornos"))
            {
                viajeRegional3.AgregarPasajero(item);
            }


            Compañia.viajesRegionales.Add(viajeRegional1);
            Compañia.viajesRegionales.Add(viajeRegional2);
            Compañia.viajesRegionales.Add(viajeRegional3);




            DateTime fecha4 = new DateTime(2022, 9, 30, 9, 36, 0);
            camarotesPremiun = embarcacion4.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion4.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional1 = new ViajeExtraRegionales(ExtraRegionales.Acapulco_México, fecha4, embarcacion4, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion4.EnViaje = true;
            foreach (var item in Compañia.harcodearP(200,"juan","martinez"))
            {
                viajeExtraRegional1.AgregarPasajero(item);
            }


            DateTime fecha5 = new DateTime(2022, 7, 10, 3, 36, 0);
            camarotesPremiun = embarcacion5.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion5.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional2 = new ViajeExtraRegionales(ExtraRegionales.Atenas_Grecia, fecha5, embarcacion5, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion5.EnViaje = false;
            foreach (var item in Compañia.harcodearP(600,"micaela","gogi"))
            {
                viajeExtraRegional2.AgregarPasajero(item);
            }

            DateTime fecha6 = new DateTime(2022, 10, 2, 8, 36, 0);
            camarotesPremiun = embarcacion7.CamarotesCantidad * 35 / 100;
            camarotesTurista = embarcacion7.CamarotesCantidad - camarotesPremiun;
            ViajeExtraRegionales viajeExtraRegional3 = new ViajeExtraRegionales(ExtraRegionales.Venecia_Italia, fecha6, embarcacion7, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion7.EnViaje = true;
            foreach (var item in Compañia.harcodearP(183,"emiliano","estor"))
            {
                viajeExtraRegional3.AgregarPasajero(item);
            }
            DateTime fecha7 = new DateTime(2022, 10, 1, 14, 44, 0);
            // no saco la cuenta de los camarotes por q es la misma embarcacion q la anterior 
            ViajeExtraRegionales viajeExtraRegional4 = new ViajeExtraRegionales(ExtraRegionales.Bangkok_Tailandia, fecha7, embarcacion7, camarotesPremiun, camarotesTurista, precioPremiumExtraRegional, precioTuristaExtraRegional);
            embarcacion7.EnViaje = true;

            foreach (var item in Compañia.harcodearP(200,"maria","irquez"))
            {
                viajeExtraRegional4.AgregarPasajero(item);
            }

            Compañia.viajesExtraRegionales.Add(viajeExtraRegional1);
            Compañia.viajesExtraRegionales.Add(viajeExtraRegional2);
            Compañia.viajesExtraRegionales.Add(viajeExtraRegional3);
            Compañia.viajesExtraRegionales.Add(viajeExtraRegional4);
            #endregion


        }

        

        /// <summary>
        /// metodo para harcodear pasajeros en un viaje 
        /// </summary>
        /// <param name="cantidad"></param>  recibe la cantidad de pasajeros a harcodear
        /// <returns></returns> devuelve una lista de pasajeros
        public static List<Pasajero> harcodearP(int cantidad, string nombre, string apellido)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            Pasajero pedro;
            for(int i = 0;i<cantidad;i++)
            {
                int numPasaporte = 18+i;
                Nacionalidad nacionalidad = Nacionalidad.Afganistán;
                Pasaporte pasaporte = new Pasaporte(DateTime.Today, numPasaporte, nacionalidad);
                int edad = 40;
                Sexo genero = Sexo.NoBinario;
                Cliente cliente = new Cliente(nombre, apellido, pasaporte, edad, genero);
                TipoPasajero tipoPasajero = TipoPasajero.Turista;

                pedro = new Pasajero(cliente, tipoPasajero);
                Bolsos valija = new Bolsos(1, Equipaje.De_Bodega);
                pedro = pedro + valija;

                pasajeros.Add(pedro);
            }
            return pasajeros;
        }


        /// <summary>
        /// busca el crucero
        /// </summary>
        /// <param name="c1"></param>
        /// <returns></returns>
        public static bool BuscarEmbarcacion(Crucero c1)
        {
            bool rta = false;
            foreach (Crucero aux in Compañia.embarcaciones)
            {
                if (c1.Equals(aux))
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }
        /// <summary>
        ///  agregar un viaje a mi lista 
        /// </summary>
        /// <param name="v1"></param> recibe viaje
        /// <returns></returns> devuelve si fue posible agrgarlo o no
        public static bool AgregarEmbarcacion(Crucero c1)
        {
            bool SeAgrego = false;
            if (!BuscarEmbarcacion(c1))
            {
                SeAgrego = true;
                Compañia.embarcaciones.Add(c1);
            }
            return SeAgrego;
        }



        #region agregar y buscar viaje , sobrecarga(regional,extraregiona)
        /// <summary>
        /// busca el viaje que recibe en mi lista
        /// </summary>
        /// <param name="v1"></param> recibe viaje 
        /// <returns></returns> devulve si lo encontro en la lista o no
        public static bool BuscarViaje(ViajeRegionales v1)
        {
            bool rta = false;
            foreach (ViajeRegionales aux in Compañia.viajesRegionales)
            {
                if (v1.Equals(aux))
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }
        /// <summary>
        ///  agregar un viaje a mi lista 
        /// </summary>
        /// <param name="v1"></param> recibe viaje
        /// <returns></returns> devuelve si fue posible agrgarlo o no
        public static bool AgregarViaje(ViajeRegionales v1)
        {
            bool SeAgrego = false;
            if (!BuscarViaje(v1))
            {
                SeAgrego = true;
                Compañia.viajesRegionales.Add(v1);
            }
            return SeAgrego;
        }
        /// <summary>
        /// busca el viaje que recibe en mi lista
        /// </summary>
        /// <param name="v1"></param> recibe viaje 
        /// <returns></returns> devulve si lo encontro en la lista o no
        public static bool BuscarViaje(ViajeExtraRegionales v1)
        {
            bool rta = false;
            foreach (ViajeExtraRegionales aux in Compañia.viajesExtraRegionales)
            {
                if (v1.Equals(aux))
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }
        /// <summary>
        ///  agregar un viaje a mi lista 
        /// </summary>
        /// <param name="v1"></param> recibe viaje
        /// <returns></returns> devuelve si fue posible agrgarlo o no
        public static bool AgregarViaje(ViajeExtraRegionales v1)
        {
            bool SeAgrego = false;
            if(!BuscarViaje(v1))
            {
                SeAgrego = true;
                Compañia.viajesExtraRegionales.Add(v1);
            }            
            return SeAgrego;
        }

        #endregion
    }
}
