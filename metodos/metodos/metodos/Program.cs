using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("pepe");
            //para acceder a esos datos y manipularlos:
            p1.SetEdad(20);
            Console.WriteLine(p1.Saludar());

            Console.WriteLine("la edad de persona es: " + p1.getEdad());

            Botella b1 = new Botella("rojo", "plastico");

            Console.WriteLine("capacidad botella: " + b1.Capacidad);
            Console.WriteLine("la cantidad actual es : " + b1.CantidadActual);

            b1.Recargar(20);
            Console.WriteLine("luego de recargar la cantidad es: " + b1.CantidadActual);

            b1.Recargar();
            Console.WriteLine("luego de recargar la cantidad es: " + b1.CantidadActual);

            Console.ReadKey();
        }
    }
}
