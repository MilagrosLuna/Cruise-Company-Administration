using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Camarote
    {
        private int capacidad;

        public Camarote()
        {
            capacidad = 4;
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

    }
}
