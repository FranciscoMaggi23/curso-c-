using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ejercicio15_Lista_Libros
{
    internal class Libros
    {
        public string _titulo;

        public Libros(string libro) 
        {
            _titulo = libro;
        }
        public string Titulo {  
            get { return _titulo; } 
            set { _titulo = value; }
        }

        public string titulo() 
        {
            return _titulo;
        }
        public override string ToString()
        {
            return _titulo;
        }

    }
}
