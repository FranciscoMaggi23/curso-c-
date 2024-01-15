using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobreEscrituraMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();

            Gatoc g1 = new Gatoc();
            g1.Nombre = "gato";

            AnimalDomestico aa1 = new AnimalDomestico();
            aa1.Nombre = "perro";

            Console.WriteLine(aa1.ToString());
            Console.WriteLine(a1.Comunicarse());
            Console.WriteLine(g1.Comunicarse());

            //ejercicio: crearemos una lista de animales

            List<Animal> animal = new List<Animal>();
            animal.Add(aa1); //agrego al perro
            animal.Add(g1); //agrego al gato
            animal.Add(new Gatoc());    //agrego un gato
            animal.Add(new Pez());
            animal.Add(new Aguila());   


            Animal a3 = g1;
            Gatoc g8 = (Gatoc)a3; //(gatoc) me convierte el objeto a tipo gatoc
            
            Console.WriteLine(g8.Nombre); //debe imprimir gato

            g8.Nombre = "blanquito";
            Console.WriteLine(g8.Nombre); //debe imprimir blanquito
            Console.WriteLine(g1.Nombre); //debe imprimir blanquito pq ambos apuntan a lo mismo(referencia o puntero)

            foreach (Animal item in animal)
            {
                Console.WriteLine(item.Comunicarse());//se comunican cada quien como sabe
                //esto es polimorfismo, es frente a un mismo estimulo responder de manera distinta
            }

            Console.ReadLine();
        }
    }
} 
