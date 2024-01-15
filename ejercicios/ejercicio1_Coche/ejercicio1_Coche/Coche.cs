using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1_Coche
{
    internal class Coche
    {
        //propiedades o atributos
        public int id {  get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int km { get; set; }
        public double precio { get; set; }

        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }
        // override = sobreescribir metodo
        public override string ToString() 
        {
            return "marca: "+marca+ " todos los demas datos";
        }

    }
}
