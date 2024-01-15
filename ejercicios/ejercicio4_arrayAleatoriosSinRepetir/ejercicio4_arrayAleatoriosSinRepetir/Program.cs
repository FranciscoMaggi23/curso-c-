using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_arrayAleatoriosSinRepetir
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

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(a.GeneararNumeroAleatotios(20, 1));
            }

            Console.WriteLine("genero 20 numeros aleatorios entre 1 y 20 en un array");
            int[] array = a.GeneararNumeroAleatotios(5, 1, 20);
            //si el array esta vacion no entra el bucle
            for (int i = 0; array != null && i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //ejercicio 4:
            //Usando la clase anterior de Aleatorios

            //– Generar un array de números no repetidos entre dos números

            Console.WriteLine("genero 20 numeros aleatorios entre 1 y 20 en un array sin repetir");
            //1_ creamos un objeto de tipo ramdon
            Aleatorios b = new Aleatorios();
            //2_ creamos un arreglo y llamamos al metodo con los parametros necesarios
            int[] sinRepetir = b.GeneararNumeroAleatotiosNoRepetidos(5,1,4);
            //imprimimos el resultado
            for (int i = 0; sinRepetir != null && i < sinRepetir.Length; i++)
            {
                Console.WriteLine(sinRepetir[i]);
            }

            Console.ReadLine();
        }
    }
}
