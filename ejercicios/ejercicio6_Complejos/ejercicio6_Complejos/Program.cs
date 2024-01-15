using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6_Complejos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase Complejo que permita trabajar con números complejos(parte real y
            //parte imaginaria). Incluye los siguientes métodos: constructores(por defecto y
            //parametrizado), accedentes, mutadores, suma, resta, multiplicación, división, 
            //acumulación y print().

            Complejo complejo1 = new Complejo(1.2,2.3);
            Complejo complejo2 = new Complejo(3.4, 2.9);

            Complejo suma = complejo2.Sumar(complejo1);
            Console.WriteLine("la suma es:");
            suma.Imprimir();

            Complejo resta = complejo1.Restar(complejo2);
            Console.WriteLine("la resta es:");
            resta.Imprimir();

            Complejo multiplicacion = complejo2.Multiplicar(complejo1);
            Console.WriteLine("la multiplicacion es");
            multiplicacion.Imprimir();

            Complejo division = complejo2.Division(complejo1);
            Console.WriteLine("la divisiion es");
            division.Imprimir();





        }
    }
}
