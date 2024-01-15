using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        // Botella: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;

        //propiedad:
        public int Capacidad
        {
            get { return capacidad; }//devolucion del valor
            set { capacidad = value; }//recepcion de eese valor y su posterior asignacion
        }
    }
}
