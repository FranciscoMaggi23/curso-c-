using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_Cafetera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolla una clase Cafetera con atributos _capacidadMaxima(la cantidad máxima
            //de café que puede contener la cafetera) y _cantidadActual(la cantidad actual de café
            //que hay en la cafetera). Implementa, al menos, los siguientes métodos: 
            // Constructor predeterminado: establece la capacidad máxima en 1000(c.c.)
            //y la actual en cero(cafetera vacía).
            // Constructor con la capacidad máxima de la cafetera; inicializa la cantidad actual de
            //café igual a la capacidad máxima.
            // Constructor con la capacidad máxima y la cantidad actual.Si la cantidad actual es
            //mayor que la capacidad máxima de la cafetera, la ajustará al máximo. 
            // Accedentes y mutadores.
            // llenarCafetera(): pues eso, hace que la cantidad actual sea igual a la capacidad.
            // servirTaza(int): simula la acción de servir una taza con la capacidad indicada.
            //Si la cantidad actual de café “no alcanza” para llenar la taza, se sirve lo que quede. 
            // vaciarCafetera(): pone la cantidad de café actual en cero. 
            // agregarCafe(int): añade a la cafetera la cantidad de café indicada.

            Cafetera cafe1 = new Cafetera(100,0);
            cafe1.llenarCafetera();
            cafe1.servirTaza(50);

            Console.WriteLine(cafe1._cantidadActual);



        }
    }
}
