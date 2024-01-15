using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio1_Coche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase Concesionario que gestione una serie de coches.

            //Tendra un array de objetos coches(anterior ejercicio)
            //y un limite de coches.

            //Crearemos los siguientes metodos:
            //– aniadirCoche(Coche c)
            //– mostrarCoches()
            //– vaciarCoches()
            //– eliminarCoche(Coche c)

            Coche auto1 = new Coche(1,"audi","tr32",345,987778.98);

            Console.WriteLine(auto1);

            // Crear un concesionario con límite de 5 coches
            Concesionario miConcesionario = new Concesionario(5);
            // Crear algunos coches
            Coche auto4 = new Coche(1, "Audi", "A3", 10000, 25000.0);
            Coche auto2 = new Coche(2, "Toyota", "Corolla", 15000, 20000.0);
            Coche auto3 = new Coche(3, "Ford", "Focus", 12000, 18000.0);


            // Añadir coches al concesionario
            miConcesionario.AnadirCoche(auto4);
            miConcesionario.AnadirCoche(auto2);
            miConcesionario.AnadirCoche(auto3);

            // Mostrar los coches en el concesionario
            miConcesionario.MostrarCoches();

            // Vaciar el concesionario
            miConcesionario.VaciarCoches();

            // Mostrar los coches después de vaciar
            miConcesionario.MostrarCoches();

            // Añadir un coche más después de vaciar
            miConcesionario.AnadirCoche(new Coche(33, "Nissan", "Altima", 18000, 22000.0));

            // Mostrar los coches después de añadir uno más
            miConcesionario.MostrarCoches();

            // Eliminar un coche del concesionario
            miConcesionario.EliminarCoche(auto2);

            // Mostrar los coches después de eliminar uno
            miConcesionario.MostrarCoches();
        
    }
    }
}
