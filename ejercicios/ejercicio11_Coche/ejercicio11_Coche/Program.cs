using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11_Coche
{
    internal class Program
    {
        static void Main(string[] args)
        {

//            Crea las siguientes clases(cada una en su archivo): 
// Motor: con métodos para arrancar el motor y apagarlo. 
// Rueda: con métodos para inflar la rueda y desinflarla. 
// Ventana: con métodos para abrirla y cerrarla. 
// Puerta: con una ventana y métodos para abrir la puerta y cerrar la puerta.
// Coche: con un motor, cuatro ruedas y dos puertas;
//            con los métodos que te parezcan adecuados.
            Coche micoche = new Coche();
            micoche.arrancar();
            micoche.desinflarRueda();
            micoche.inflarRuedas();
            micoche.apagado();

        }
    }
}
