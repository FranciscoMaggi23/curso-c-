using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_Cafetera
{
    internal class Cafetera
    {
        //atributos
        public double _capacidadMaxima;
        public double _cantidadActual;

        // Constructor predeterminado: establece la capacidad máxima en 1000(c.c.)
        //y la actual en cero(cafetera vacía).
        public Cafetera()
        {
            _capacidadMaxima = 1000;
            _cantidadActual = 0;
        }
        // Constructor con la capacidad máxima de la cafetera; inicializa la cantidad actual de
        //café igual a la capacidad máxima.
        public Cafetera(double capacidadMaxima)
        {
            _cantidadActual = capacidadMaxima;
        }
        // Constructor con la capacidad máxima y la cantidad actual.Si la cantidad actual es
        //mayor que la capacidad máxima de la cafetera, la ajustará al máximo. 
        public Cafetera(double capacidadMaxima, double cantidadActual)
        {
            //if (capacidadMaxima < cantidadActual)
            //{
            //    _cantidadActual = capacidadMaxima;
            //}

            //En este caso, Math.Min(capacidadMaxima, cantidadActual) asegura que la cantidad actual no sea mayor que la capacidad máxima.
            _cantidadActual = Math.Min(capacidadMaxima, cantidadActual);
            _capacidadMaxima= capacidadMaxima;
        }
        // Accedentes y mutadores.
        public double CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set { _capacidadMaxima = value; }
        }

        public double CantidadActual
        {
            get { return _cantidadActual; }
            set { _cantidadActual = value; }
        }


        // llenarCafetera(): pues eso, hace que la cantidad actual sea igual a la capacidad.
        public void llenarCafetera()
        {
            _cantidadActual = _capacidadMaxima;
        }
        // servirTaza(int): simula la acción de servir una taza con la capacidad indicada.
        //Si la cantidad actual de café “no alcanza” para llenar la taza, se sirve lo que quede. 
        public void servirTaza(int cant)
        {
            if(_cantidadActual < cant)
            {
                Console.WriteLine($"no se lleno la taza\n");
                _cantidadActual = 0;
            }
            else
            {
                Console.WriteLine("la taza esta llena");
                _cantidadActual -= cant;
            }
        }

        // vaciarCafetera(): pone la cantidad de café actual en cero. 
        public void vaciarCafetera()
        {
            _cantidadActual = 0;
        }
        // agregarCafe(int): añade a la cafetera la cantidad de café indicada.
        public void agregarCafe(int cant)
        {
            _cantidadActual += cant;
        }


    }
}
