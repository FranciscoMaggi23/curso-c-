using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobreEscrituraMetodos
{
    internal class Animal
    {
        //para´poder sobreescribir metodos en otros objetos, dicho metodo tiene q ser "virtual" 
        public virtual string Comunicarse()
        {
            return "ruido ruido";
        }
    }
}
