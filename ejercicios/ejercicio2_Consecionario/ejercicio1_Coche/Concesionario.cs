using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_Coche
{
    internal class Concesionario
    {
        public Coche[] ArrayCoche { get; set; }//declaracion array
        /*public Concesionario(int limiteCoches): Este es el constructor de la
         * clase Concesionario. Se ejecutará automáticamente cuando se cree
         * una nueva instancia de la clase Concesionario. Recibe un
         * parámetro limiteCoches, que indica el límite máximo de coches
         * que el concesionario puede almacenar */
        public Concesionario(int limite) 
        {
            ArrayCoche = new Coche[limite];
        }
        public void AnadirCoche(Coche nuevoCoche)
        {
            for (int i = 0; i < ArrayCoche.Length; i++)
            {
                if (ArrayCoche[i] == null)
                {
                    ArrayCoche[i] = nuevoCoche;
                    return; // Termina el método después de añadir el coche
                }
            }

            Console.WriteLine("No hay espacio disponible para añadir más coches.");
        }

        public void MostrarCoches()
        {
            Console.WriteLine("Coches en el concesionario:");
            foreach (Coche coche in ArrayCoche)
            {
                if (coche != null)
                {
                    Console.WriteLine(coche);
                }
            }
        }

        public void VaciarCoches()
        {
            Array.Clear(ArrayCoche, 0, ArrayCoche.Length);
            Console.WriteLine("Se han vaciado todos los coches en el concesionario.");
        }

        public void EliminarCoche(Coche coche)
        {
            for (int i = 0; i < ArrayCoche.Length; i++)
            {
                if (ArrayCoche[i] == coche)
                {
                    ArrayCoche[i] = null;
                    Console.WriteLine("Coche eliminado del concesionario.");
                    return; // Termina el método después de eliminar el coche
                }
            }

            Console.WriteLine("El coche no se encuentra en el concesionario.");
        }
    }

}

