using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5_Ordenador
{
    internal class Ordenador
    {
        private int tamanioDiscoGB;
        private int tamanioDiscoMaxGB;
        private bool encendido;

        private const int TAMANIO_DEFECTO = 100;
        public Ordenador(int tamMaxGB)
        {
            this.tamanioDiscoGB = 0;
            this.encendido=false;

            if(tamMaxGB<=0)
            {
                this.tamanioDiscoMaxGB = TAMANIO_DEFECTO;
            }
            else
            {
                this.tamanioDiscoMaxGB= tamMaxGB;
            }

        }
        //– aniadirDatos(int datos): añade informacion al disco duro, si supera el maximo del tamaño del disco,
        //el tamanio del disco sera el maximo posible.Solo si esta encendido el ordenador.
         public void añadirDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("los GB tienen q ser mayor a cero");
                }
                else
                {
                    if (this.tamanioDiscoGB + datos > this.tamanioDiscoMaxGB)
                    {
                        this.tamanioDiscoGB= this.tamanioDiscoMaxGB;
                        Console.WriteLine("disco duro lleno");
                    }
                    else
                    {
                        this.tamanioDiscoGB+= datos;
                        Console.WriteLine("se ha añadido datos "+ this.tamanioDiscoGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("el ordenador debe estar encendido...");
            }
        }
        //– eliminarDatos(int datos): elimina informacion al disco duro, si el tamaño del disco es menor que 0,
        //el tamanio del disco se quedara a 0.Solo si esta encendido el ordenador.
        public void eliminarDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    Console.WriteLine("los GB tienen q ser mayor a cero");
                }
                else
                {
                    if (this.tamanioDiscoGB - datos <= 0)
                    {
                        this.tamanioDiscoGB = 0;
                        Console.WriteLine("disco duro vacio");
                    }
                    else
                    {
                        this.tamanioDiscoGB -= datos;
                        Console.WriteLine("se ha eliminado datos, ahora hay: " + this.tamanioDiscoGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("el ordenador debe estar encendido...");
            }
        }
        //– encender(): enciende el ordenador.
        public void encender()
        {
            this.encendido = true;
        }

        //– apagar(): apaga el ordenador.
        public void apagar()
        {
            this.encendido=false;
        }




    }
}
