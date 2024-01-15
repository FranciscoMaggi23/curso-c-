using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoresYdestructores
{
    internal class Botella
    {
        //constructor
        public Botella(string color, string material)
        {
            //this es un apuntador(puntero) a la clase, es decir la que esta fuera de esta funcion
            this.color = color;
            this.material = material;
        }
        //sobrecarga el constructor(significa que podes volver a crear el mismo constructor("Botella") pero con otras caracteristicas
        public Botella() { }    //sin parametros nos puede servir para crear un objeto vacio


        //destructor:
        ~Botella()
        {
            //logica...el garbash colector lo ejecutara para limpiar memoria 
            // no se usa tanto en este lenguaje
        } 


        // Botella: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;

        public string Material
        {
            get { return material; }    
        }

        //propiedad:
        public int Capacidad
        {
            get { return capacidad; }//devolucion del valor
            set { capacidad = value; }//recepcion de eese valor y su posterior asignacion
        }
    }
}
