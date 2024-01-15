using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase Aleatorios

            //Como atributo tendra un Random.

            //Tendra los siguientes metodos:

            //– Generar un numero entre 2 numeros
            //– Generar un array de numeros entre dos numeros


            //genero 20 numeros aleatorios entre 1 y 20
            Aleatorios a = new Aleatorios();

            for (int i = 0; i<20; i++) 
            {
                Console.WriteLine(a.GeneararNumeroAleatotios(20,1));
            }

            Console.WriteLine("genero 20 numeros aleatorios entre 1 y 20 en un array");
            int[] array = a.GeneararNumeroAleatotios(5, 1, 20);
            //si el array esta vacion no entra el bucle
            for (int i = 0;array!=null && i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            } 
            Console.ReadLine();

        }
    }
}
//ok