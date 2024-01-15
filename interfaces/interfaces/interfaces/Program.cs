using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();

            Canario g1 = new Canario();
            g1.Nombre = "cana";

            AnimalDomestico aa1 = new AnimalDomestico();
            aa1.Nombre = "perro";

            List<Animal> animal = new List<Animal>();
            animal.Add(aa1); //agrego al perro
            animal.Add(g1); //agrego al gato
            animal.Add(new Canario());    //agrego un gato
            animal.Add(new Aguila());


            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            //no le puedo agregar cuanquier animal(objeto) solo los que me lo permita mi interfaz
            //listaVoladores.Add(new Perro());



            //esto no se puede hacer:
            //Flyable f1 = new Flyable(); 

        }
    }
}
