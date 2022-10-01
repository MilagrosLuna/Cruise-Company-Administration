using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Camarote
    {
        /// <summary>
        /// clase camarote creada para cruceros 
        /// que tienen cierta cantidad pero a la vez 
        /// todos los camarotes tienen capacidad para 4 personas
        /// </summary>
        private static int capacidad;

        /// <summary>
        /// constructor del camarote
        /// </summary>
        public Camarote()
        {
            capacidad = 4;
        }
        /// <summary>
        /// propiedad que devulve la capacidad 
        /// </summary>
        public static int Capacidad
        {
            get { return Camarote.capacidad; }
        }

    }
}
