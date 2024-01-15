using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11_Coche
{
    internal class Puerta
    {
        private Ventana ventana;

        public Puerta()
        {
            ventana = new Ventana();
        }
        public void abrirPuerta()
        {
            Console.WriteLine("puerta abierta");
            ventana.abrirVentana();

        }
        public void cerrarPuerta()
        {
            Console.WriteLine("puerta cerrada");
            ventana.cerrarVentana();
        }
    }
}
