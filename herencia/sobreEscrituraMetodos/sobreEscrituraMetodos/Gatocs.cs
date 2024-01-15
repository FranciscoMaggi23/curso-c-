using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobreEscrituraMetodos
{
    internal class Gatoc : AnimalDomestico
    {
        //es necesario que en el modulo Animal este la caracteristica Virtual 
        public override string Comunicarse()
        {
            return "miau miau";
        }
    }
}
