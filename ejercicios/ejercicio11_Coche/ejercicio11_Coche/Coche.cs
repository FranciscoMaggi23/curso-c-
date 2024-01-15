using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11_Coche
{
    internal class Coche
    {
        private Motor motor;
        private Rueda[] rueda;
        private Puerta[] puerta;

        public Coche()
        {
            motor = new Motor();
            rueda = new Rueda[4];
            for (int i = 0; i < 4; i++)
            {
                rueda[i] = new Rueda();
            }
            puerta = new Puerta[4];
            for (int i = 0; i < 4; i++)
            {
                puerta[i] = new Puerta();

            }
        }
        public void arrancar()
        {
            motor.encender();
        }
        public void apagado()
        {
            motor.apagar();
        }
        public void inflarRuedas()
        {
            for (int i = 0;i < 4;i++)
            {
                rueda[i].inflar();
            }
        }
        public void desinflarRueda()
        {
            for (int i = 0; i < 4; i++)
            {
                rueda[i].desinflar();
            }
        }
        public void abrir()
        {
            for (int i = 0; i < 4; i++)
            {
                puerta[i].abrirPuerta();
                
            }
        }
        public void cerrar()
        {
            for (int i = 0; i < 4; i++)
            {
                puerta[i].cerrarPuerta();
            }
        }


    }
}
