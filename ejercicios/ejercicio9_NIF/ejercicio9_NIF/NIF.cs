using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_NIF
{
    internal class NIF
    {
        //Los atributos serán el número de DNI(entero largo) y la letra que le corresponde. 
        private long _id;
        private char _letra;

        // Constructor predeterminado que inicialice el nº de DNI a 0 y la letra a espacio en
        //blanco(será un NIF no válido).
        public NIF()
        {
            _id = 0;
            _letra =' ';
        }

        // Constructor que reciba el DNI y establezca la letra que le corresponde. 
        public NIF(long id)
        {
            EstablecerDni(id);
        }

        // Accedentes y mutador para el número de DNI(que ajuste automáticamente la letra). 
        public long DNI
        {
            get { return _id; }
            set { EstablecerDni(value); }
        }


        //calcular letras
        public char CalcularLetras()
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int indice = (int)(_id % 23);
            char letra = letras[indice];
            return letra;
        }

        // Método para establecer el número de DNI y ajustar automáticamente la letra
        public void EstablecerDni(long id)
        {
            _id = id;
            _letra = CalcularLetras();
        }

        // leer(): que pida el número de DNI(ajustando automáticamente la letra)
        public void leer()
        {
            Console.Write("Ingrese el número de DNI: ");
            if (long.TryParse(Console.ReadLine(), out long nuevoDNI))
            {
                EstablecerDni(nuevoDNI);
                Console.WriteLine("DNI y letra actualizados correctamente.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. El número de DNI no ha sido actualizado.");
            }
        }
        // Método que nos permita mostrar el NIF(ocho dígitos, un guión y la letra en
        //mayúscula; por ejemplo: 00395469 - F) 
        public void MostrarNIF()
        {
            Console.WriteLine($" el nif es: {_id} - " + char.ToUpper(_letra));
        }


    }
}


//La ventaja de usar TryParse en lugar de métodos como Convert.ToInt64 o 
//    long.Parse es que TryParse no arrojará una excepción si la conversión falla.
//    En cambio, permite manejar el fallo de una manera más controlada utilizando el valor 
//    predeterminado y evita que la aplicación se cierre inesperadamente.