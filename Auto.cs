using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9EjercicioNueve
{
    class Auto
    {
        private string _patente;

        public Auto(string Patente)
        {
            this._patente = Patente;
        }

        public static bool operator ==(Auto Auto1, Auto Auto2)
        {
            bool resultado = Auto1._patente == Auto2._patente;

            return resultado;
        }

        public static bool operator !=(Auto Auto1, Auto Auto2)
        {
            return !(Auto1 == Auto2);
        }
    }
}
