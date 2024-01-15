using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCoche
{
    internal class Coche
    {
        //            – ID
        //            – Marca
        //            – Modelo
        //            – KM
        //            – Precio
        private string id;
        private string  marca;
        private string modelo;
        private int km;
        private float precio;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //            Debemos crear un constructor donde le pasemos los valores.
        public Coche(string id, string marca, string modelo,int km, float precio )
        {
            this.id = id;
            this.marca = marca; 
            this.modelo = modelo;   
            this.km = km;   
            this.precio = precio;       
        }
        //Crea el metodo toString

        public string ToString()
        {
            return $"ID: {Id}\nMarca: {Marca}\nModelo: {Modelo}\nKM: {Km}\nPrecio: {Precio:C}";
        }

    }
}
