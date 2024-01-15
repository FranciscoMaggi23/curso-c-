using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio:
             * primer lote con 10 registros de productos, cada prooducto tiene:
             * - codigo de articulo(3 digitos no correlativos)
             * -precio
             * -codigo de marca(1 a 10)
             * segundo lote con las ventas de la semana. cada semana tiene:
             * -codigo de articulo
             * -cantidad
             * -codigo cliente
             * este lote corta con codigo de cliente cero
             */

            //para guardar 10 articulos nos comviene usar un verctor

            Articulo[] articulos = new Articulo[10];
            
            //cargar el vector de tipo articulo
            for (int i = 0; i < 3; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("ingrese codigo de articulo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());    
                Console.WriteLine("ingrese codigo marca (1 a 10): ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());   

            }


            Venta venta = new Venta();
            Console.WriteLine("ingrese la venta:");
            Console.WriteLine("ingrese codigo cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("ingrese codigo articulo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido cliente nuevamente:
                Console.WriteLine("ingrese la venta:");
                Console.WriteLine("ingrese codigo cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }





        }
    }
}
