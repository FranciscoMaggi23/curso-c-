using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_NIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una clase NIF que se usará para mantener DNIs con su correspondiente letra. 
            //Los atributos serán el número de DNI(entero largo) y la letra que le corresponde. 
            //La clase dispondrá de los siguientes métodos:
            // Constructor predeterminado que inicialice el nº de DNI a 0 y la letra a espacio en
            //blanco(será un NIF no válido).
            // Constructor que reciba el DNI y establezca la letra que le corresponde. 
            // Accedentes y mutador para el número de DNI(que ajuste automáticamente la letra). 
            // leer(): que pida el número de DNI(ajustando automáticamente la letra)
            // Método que nos permita mostrar el NIF(ocho dígitos, un guión y la letra en
            //mayúscula; por ejemplo: 00395469 - F) 
            //La letra se calculará con un método auxiliar(privado) de la siguiente forma: 
            //se obtiene el resto de la división entera del número de DNI entre 23 y se usa la
            //siguiente tabla para obtener la letra que corresponde: 
            // 0 - T 1 - R 2 - W 3 - A 4 - G 5 - M 6 – Y
            // 7 - F 8 - P 9 - D 10 - X 11 - B 12 - N 13 – J14 - Z 15 - S 16 - Q 17 - V 18 - H 19 - L 20 – C
            //21 - K 22 – E

            NIF nuevonif = new NIF(1234567);
            nuevonif.EstablecerDni(4569);
            nuevonif.MostrarNIF();

            nuevonif.leer();
            nuevonif.MostrarNIF();


        }
    }
}
