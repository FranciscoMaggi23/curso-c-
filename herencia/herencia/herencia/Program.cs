using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //persona > lider > developer > tester

            
            Persona p1 = new Persona();
            Developers d1 = new Developers();
            Lider l1 = new Lider();

            /*vehiculos >autos > autoDeportivo > autoUrbano
             * >camioneta
             * >moto
             */
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();

            //guardar un dato de tipo camioneta demtro de un dato de tipo vehiculo
            //esto puede darse pq camioneta esta incluida en la clase vehiculo("es de la familia")
            Vehiculo v2 = new Camioneta();
            //en cambio esto no se puede hacer:
            //Camioneta c2 = new Vehiculo();
        }
    }
}
