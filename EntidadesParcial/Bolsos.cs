using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Bolsos
    {
        private int peso;
        private Equipaje tipoEquipaje;

        public int Peso
        {
            get { return peso; }
        }

        private Bolsos()
        {
            this.peso = 0;
            this.tipoEquipaje = Equipaje.NoCargado;
        }
        public Bolsos(int peso, Equipaje equipaje):this()
        {
            if(peso > 0 && equipaje != Equipaje.NoCargado)
            {
                this.peso = peso;
                this.tipoEquipaje = equipaje;
            }
        }

        private string MostrarBolso()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append($" Tipo: {this.tipoEquipaje},");
            cadena.AppendLine($" Peso: {this.peso} ");

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarBolso();
        }
    }
}
