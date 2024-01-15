using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5_Ordenador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase Ordenador con los siguientes atributos:

            //– tamanio disco(GB)
            //– tamanio disco max(GB)
            //– encendido

            //Los metodos a añadir son:

            //– aniadirDatos(int datos): añade informacion al disco duro, si supera el maximo del tamaño del disco, el tamanio del disco sera el maximo posible.Solo si esta encendido el ordenador.
            //– eliminarDatos(int datos): elimina informacion al disco duro, si el tamaño del disco es menor que 0, el tamanio del disco se quedara a 0.Solo si esta encendido el ordenador.
            //– encender(): enciende el ordenador.
            //– apagar(): apaga el ordenador.

            Ordenador pc = new Ordenador(500);

            pc.encender();

            pc.añadirDatos(100);
            pc.apagar();
            pc.eliminarDatos(20);





            Console.ReadLine();

        }
    }
}
