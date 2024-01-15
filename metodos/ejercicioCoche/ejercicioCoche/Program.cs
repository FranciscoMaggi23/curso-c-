using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicioCoche
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            1.Crea una clase Coche con las siguientes propiedades:

//            – ID
//            – Marca
//            – Modelo
//            – KM
//            – Precio

//            Debemos crear un constructor donde le pasemos los valores.

            //Crea sus get y set de cada propiedad.

            //Crea el metodo toString

            Coche v1 = new Coche("hola","doge","e323",11,124);

            Console.WriteLine(v1.ToString());
        }
    }
}
