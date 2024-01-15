using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: edad, sueldo, Nombre
            //para cargar datos:
            int edad;
            float sueldo;
            string nombre;
            //si quisiera guardar los datos de 10 personas:
            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres = new string[10];

            //puedo crear mi variable de tipo Persona:
            Persona p1 = new Persona("pepe");
            //para acceder a esos datos y manipularlos:
            p1.SetEdad(20);
            Console.WriteLine(p1.saludar());

            Console.WriteLine("la edad de persona es: " + p1.getEdad());

           

            Console.ReadKey();
        }
    }
}
