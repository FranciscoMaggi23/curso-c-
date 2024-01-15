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
            Persona p1 = new Persona();
            //para acceder a esos datos y manipularlos:
            p1.SetEdad(20);

            Console.WriteLine("la edad de persona es: " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad;
            //le agrego un comentario para probar los controles de git...

            Perro perro1 = new Perro();
            perro1.Nombre = "pepe";
            perro1.Origen = "junin";
            Console.WriteLine("ingrese color del perro: ");
            perro1.Color = Console.ReadLine();

            Console.WriteLine("caracteristicas de perro1: " + perro1.Color +"\n" + perro1.Origen + "\n"+ perro1.Nombre);


            Console.ReadKey();
        }
    }
}
