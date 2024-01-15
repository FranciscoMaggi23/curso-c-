using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        //atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;


        //contructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
            numeroTelefonico = "1234";
        }

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }    
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value < 4 && value > 0)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }

        }
        //metodo llamar()
        public string Llamar()
        {
            return "realizando llamada";
        }
        //sobrecargando llamada
        public string Llamar(string contacto)
        {
            return "llamando a... " + contacto;
        }

    }
}
