using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Persona
    {
        //Persona: edad, sueldo, Nombre
        //atributos o miembros(variables que guardan inf)
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int e)
        {
            edad = e;
        }
        //obtener el valor de la variable edad
        public int getEdad()
        {
            return edad;
        }

        //METODOS
        public string Saludar()
        {
            return "hola soy..." + nombre;

        }

        //sobrecarga de metodo, la diferencia es la cantidad de parametros q recibe
        public string Saludar(string personaje)
        {
            return "hola " + personaje + " soy " + nombre;
        }
    }
}
