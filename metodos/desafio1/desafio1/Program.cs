using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono Telefono = new Telefono("nokia","2001");
            Telefono.CodigoOperador = 6;

            Console.WriteLine("codigo operador: "+Telefono.CodigoOperador);
            Console.WriteLine("numero: " + Telefono.NumeroTelefonico);
            Console.WriteLine("marca: " + Telefono.Marca);
            Console.WriteLine("modelo: " + Telefono.Modelo);
            Console.WriteLine(Telefono.Llamar());
            Console.WriteLine("sobrecarga: " + Telefono.Llamar("raul"));







        }
    }
}
