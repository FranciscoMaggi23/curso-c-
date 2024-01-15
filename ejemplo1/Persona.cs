using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, Nombre
        //atributos o miembros(variables que guardan inf)
        private int edad;
        private float sueldo;
        private string nombre;

        public void SetEdad(int e)
        {
            edad = e;
        }
        //obtener el valor de la variable edad
        public int getEdad()
        {
            return edad;
        }

       
    }
}
