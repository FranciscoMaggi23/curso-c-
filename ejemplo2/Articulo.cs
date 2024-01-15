using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //- codigo de articulo(3 digitos no correlativos)
        //-precio
        //-codigo de marca(1 a 10)

        //private int codigoArticulo;

        //otra forma de escribirlo:
        //la diferencia es que de esta forma es mas corto pero no puedo manipular lo que pasa con el set y get
        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }

        private int codigoMarca;
        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if (value > 0 && value < 11)
                {
                    codigoMarca = value;
                }
                else
                    codigoMarca = -1;
            }
        }





    }
}
