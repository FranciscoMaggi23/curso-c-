using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Botella
    {
        //capacidad maxima:100
        //cantidadActual: inicia en cero
        //metodo de carga: carga al 100 y devuelve el costo de recargar. 50 cada 100
        //constructor
        public Botella(string color, string material)
        {
            //this es un apuntador(puntero) a la clase, es decir la que esta fuera de esta funcion
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
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
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }

        //propiedad:
        /* public int Capacidad
         {
             get { return capacidad; }//devolucion del valor
             set { capacidad = value; }//recepcion de eese valor y su posterior asignacion

         }*/

        //metodo
        public float Recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;

        }
        //sobrecarga de metodos
        public float Recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad*50 /100;
        }

    }
}
