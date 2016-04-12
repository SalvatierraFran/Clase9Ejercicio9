using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9EjercicioNueve
{
    class Estacionamiento
    {
        public string NombreDeEstacionamiento;
        public Auto[] ListadoDeAutos;
        //El array hay que instanciarlo y controlar que sus objetos no estén en null

        public int CantidadDeCocheras;

        public Estacionamiento(string NombreDueño, int CantiCocheras)
        {
            this.NombreDeEstacionamiento = NombreDueño;
            this.CantidadDeCocheras = CantiCocheras;
            this.ListadoDeAutos = new Auto[CantiCocheras];
        }

        public bool EstacionarAuto(Auto UnAuto)
        {
            bool EstaLleno = false;

            if (this != UnAuto)
            {
                for (int i = 0; i < this.ListadoDeAutos.GetLength(0); i++)
                {
                    if (this.ListadoDeAutos.GetValue(i) == null)
                    {
                        //EstaLleno = false;
                        this.ListadoDeAutos[i] = UnAuto;
                        break;
                    }

                    if (i == this.CantidadDeCocheras - 1)
                    {
                        EstaLleno = true;
                    }
                }
            }
            else
            {
                //el auto estaba
            }

            return EstaLleno;
        }

        public static bool operator ==(Estacionamiento UnEstacionamiento, Auto UnAuto)
        {
            bool respuesta = false;

            foreach (Auto AutoRecorriendo in UnEstacionamiento.ListadoDeAutos)//Foreach para recorrer. For para modificar.
            {
                if ((object)AutoRecorriendo!=null && AutoRecorriendo == UnAuto)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Estacionamiento UnEstacionamiento, Auto UnAuto)
        {
            return !(UnEstacionamiento == UnAuto);
        }
    }
}
