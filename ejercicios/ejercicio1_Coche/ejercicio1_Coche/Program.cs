using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio1_Coche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase Coche con las siguientes propiedades:

            //– ID
            //– Marca
            //– Modelo
            //– KM
            //– Precio

            //Debemos crear un constructor donde le pasemos los valores.

            //Crea sus get y set de cada propiedad.

            //Crea el metodo toString.

            //— Coche

            Coche auto1 = new Coche(1,"audi","tr32",345,987778.98);

            Console.WriteLine(auto1);
        }
    }
}
