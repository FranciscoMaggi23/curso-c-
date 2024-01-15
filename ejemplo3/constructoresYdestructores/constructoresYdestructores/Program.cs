using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoresYdestructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //un constructor es la funcion que se ejecuta cuando creamos la instancia de un objeto
            // a botella ahora le pasamos los argumentos que pide el constructor
            Botella b2 = new Botella("rojo", "plastico");
            b2.Capacidad = 200;

            //objeto botella con constructor vacio:
            Botella b3 = new Botella(); 
        }
    }
}
