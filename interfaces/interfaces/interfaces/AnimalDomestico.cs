using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //sobreescribir metodo toString()
        public override string ToString()
        {
            return "animal: " + Nombre;
        }
    }
}
