using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Aguila : Animal, Flyable
    {
        public string Volar()
        {
            return "vuela aguila";
        }
    }
}
