using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13_InvertirNumeros
{
    internal class InvertirNum
    {
        private int[] _num;

        public InvertirNum()
        {
            _num = new int[10];
        }
       
        public void IngresarNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out _num[i]))
                {
                    // Se ingresó un número válido
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                    i--; // Decrementar el índice para repetir la entrada
                }
            }
        }
        public void MostrarNumerosEnOrdenInverso()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.Write($"{_num[i]} ");
            }
            Console.WriteLine();
        }
    }
}
