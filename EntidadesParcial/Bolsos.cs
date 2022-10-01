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

        /// <summary>
        /// propiedad que devuelve el peso del bolso
        /// </summary>
        public int Peso
        {
            get { return peso; }
        }
        /// <summary>
        /// constructor base de bolso, inicializa sus atributos
        /// </summary>
        private Bolsos()
        {
            this.peso = 0;
            this.tipoEquipaje = Equipaje.NoCargado;
        }
        /// <summary>
        /// constructor de bolso con parametros
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="equipaje"></param>
        public Bolsos(int peso, Equipaje equipaje):this()
        {
            if(peso > 0 && equipaje != Equipaje.NoCargado)
            {
                this.peso = peso;
                this.tipoEquipaje = equipaje;
            }
        }
        /// <summary>
        /// metodo mostrar que se utiliza en la sobrecarga del Bolso.toString()
        /// </summary>
        /// <returns></returns> cadena con datos del bolso
        private string MostrarBolso()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append($" Tipo: {this.tipoEquipaje},");
            cadena.AppendLine($" Peso: {this.peso} ");

            return cadena.ToString();
        }
        /// <summary>
        /// sobrecarga del to string con los datos de bolso
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarBolso();
        }
    }
}
