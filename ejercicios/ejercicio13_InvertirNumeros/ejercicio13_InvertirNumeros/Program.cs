using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13_InvertirNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida diez números enteros y los muestre en orden inverso(del
            //último leído hasta el primero). 

            // Crear una instancia de la clase NumerosManager
            InvertirNum numerosManager = new InvertirNum();

            // Pedir al usuario que ingrese diez números
            numerosManager.IngresarNumeros();

            // Mostrar los números en orden inverso
            Console.WriteLine("\nNúmeros en orden inverso:");
            numerosManager.MostrarNumerosEnOrdenInverso();
        }
    }
}
