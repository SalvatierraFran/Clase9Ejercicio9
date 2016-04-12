using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9EjercicioNueve
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento MiEstacionamiento = new Estacionamiento("Franco", 3);

            //MiEstacionamiento.EstacionarAuto(new Auto("IVM991"));
            //MiEstacionamiento.EstacionarAuto(new Auto("IVM992"));
            //MiEstacionamiento.EstacionarAuto(new Auto("IVM993"));
            //MiEstacionamiento.EstacionarAuto(new Auto("IVM994"));

            Auto Auto1 = new Auto("IVM991");
            MiEstacionamiento.EstacionarAuto(Auto1);

            Auto Auto2 = new Auto("IVM992");
            MiEstacionamiento.EstacionarAuto(Auto2);

            Auto Auto3 = new Auto("IVM993");
            MiEstacionamiento.EstacionarAuto(Auto3);

            Auto Auto4 = new Auto("IVM994");
            MiEstacionamiento.EstacionarAuto(Auto4);

            Console.ReadKey();
        }
    }
}
