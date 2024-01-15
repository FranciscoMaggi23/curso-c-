using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public string Volar()
        {
            return "vuela canario";
        }
    }
}
