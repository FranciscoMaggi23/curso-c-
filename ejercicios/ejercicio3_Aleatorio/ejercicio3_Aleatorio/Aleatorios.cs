using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ejercicio3_Aleatorio
{
    internal class Aleatorios
    {
        /*En C#, Random es una clase que pertenece al espacio de nombres System.
         * Esta clase se utiliza para generar secuencias de números pseudoaleatorios. 
         * Cuando creas una instancia de la clase Random, puedes utilizar sus métodos
         * para obtener números aleatorios dentro de un rango específico o para generar
         * diferentes tipos de valores aleatorios.
         */
        private Random _random;

        public Aleatorios() 
        {
            this._random = new Random();
        }
        //El método Next toma dos parámetros: el valor mínimo(inclusive)
        //y el valor máximo(exclusive). Por lo tanto, el rango real es[mínimo, máximo).
        public int GeneararNumeroAleatotios(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }
            //le ponemos +1 pq sino se le resta uno a la posicion
            return this._random.Next(min, max+1);
        }
        //le pasamos la longitud del array
        public int[] GeneararNumeroAleatotios(int longitud, int min, int max)
        {
            if(longitud<=0)
            {
                return null;
            }
            int[] numeros = new int[longitud];
            for(int i=0; i< numeros.Length; i++)
            {
                numeros[i] = GeneararNumeroAleatotios(min, max);
            }
            return numeros;
        }
    }
}
