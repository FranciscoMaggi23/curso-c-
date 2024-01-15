using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Crea una clase Hora con atributos para las horas, los minutos y los segundos de la hora. 
            //Incluye, al menos, los siguientes métodos: 
            // Constructor predeterminado con el 00:00:00 como hora por defecto. 
            // Constructor parametrizado con horas, minutos y segundos. 
            // leer(): pedirá al usuario las horas, los minutos y los segundos.
            // valida(): comprobará si la hora es correcta; si no lo es la ajustará. Será un método
            //auxiliar(privado) que se llamará en el constructor parametrizado y en leer(). 
            // Accedentes y mutadores.
            // print(): mostrará la hora(07:03:21).
            // aSegundos(): devolverá el número de segundos transcurridos desde la medianoche.
            // deSegundos(int): hará que la hora sea la correspondiente a haber transcurrido
            //desde la medianoche los segundos que se indiquen. 
            // segundosDesde(Hora): devolverá el número de segundos entre la hora y la
            //proporcionada.
            // siguiente(): pasará al segundo siguiente. 
            // anterior(): pasará al segundo anterior. 
            // copia(): devolverá un clon de la hora. 
            // igualQue(Hora): indica si la hora es la misma que la proporcionada. 
            // menorQue(Hora): indica si la hora es anterior a la proporcionada.
            // mayorQue(Hora): indica si la hora es posterior a la proporcionada.



            // Crear una instancia de Hora
            Hora miHora = new Hora();

            // Leer valores del usuario
            miHora.leer();

            // Mostrar la hora en formato corto
            Console.WriteLine($"Hora ingresada: {miHora._hora:D2}:{miHora._minutos:D2}:{miHora._segundos:D2}");

            // Calcular y mostrar los segundos desde la medianoche
            Console.WriteLine($"Segundos desde la medianoche: {miHora.aSegundos()} segundos");

            // Crear una copia de la hora
            Hora copiaHora = miHora.copia();
            Console.WriteLine("Copia de la hora creada.");

            // Mostrar la copia de la hora
            Console.WriteLine($"Copia de la hora: {copiaHora._hora:D2}:{copiaHora._minutos:D2}:{copiaHora._segundos:D2}");


        }
    }
}
//listo q capo q soy