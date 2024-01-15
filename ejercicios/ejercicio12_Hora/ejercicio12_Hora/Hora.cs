using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12_Hora
{
    internal class Hora
    {
        private int hora;
        private int minutos;
        private int segundos;

        // Constructor predeterminado con el 00:00:00 como hora por defecto. 
        public Hora()
        {
            hora=00;
            minutos=00;
            segundos=00;
        }
        // Constructor parametrizado con horas, minutos y segundos. 
        public Hora(int hora, int minutos, int segundos)
        {
            this.hora=hora;     
            this.minutos=minutos;
            this.segundos=segundos;
        }
        // leer(): pedirá al usuario las horas, los minutos y los segundos.
        public void leer()
        {
            Console.WriteLine("ingrese la hora:");
            this.hora= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese los minutos:");
            this.minutos = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese los segundos:");
            this.segundos = int.Parse(Console.ReadLine());
            valida();


            /*segurn chatGPT:  Podrías considerar el uso de int.TryParse() para manejar posibles errores de entrada.
             * 
            Console.WriteLine("Ingrese la hora:");
            int inputHora;
            while (!int.TryParse(Console.ReadLine(), out inputHora) || inputHora < 0 || inputHora >= 24)
            {
                Console.WriteLine("Hora inválida. Ingrese nuevamente:");
            }
            this.hora = inputHora;

            Console.WriteLine("Ingrese los minutos:");
            int inputMinutos;
            while (!int.TryParse(Console.ReadLine(), out inputMinutos) || inputMinutos < 0 || inputMinutos >= 60)
            {
                Console.WriteLine("Minutos inválidos. Ingrese nuevamente:");
            }
            this.minutos = inputMinutos;

            Console.WriteLine("Ingrese los segundos:");
            int inputSegundos;
            while (!int.TryParse(Console.ReadLine(), out inputSegundos) || inputSegundos < 0 || inputSegundos >= 60)
            {
                Console.WriteLine("Segundos inválidos. Ingrese nuevamente:");
            }
            this.segundos = inputSegundos;

            valida();
             */



        }
        // valida(): comprobará si la hora es correcta; si no lo es la ajustará. Será un método
        //auxiliar(privado) que se llamará en el constructor parametrizado y en leer(). 

        public void valida()
        {
            if(this.hora<0 || this.hora>24) 
            {
                this.hora = 0;
            }
            if (this.minutos < 0 || this.minutos >= 60)
            {
                this.minutos = 0;
            }
            if (this.segundos < 0 || this.segundos > 60)
            {
                this.segundos = 0;
            }
        }
        // Accedentes y mutadores.
        public int _hora
        {
            get {  return this.hora; }
            set { this.hora = value; }
        }
        public int _minutos
        {
            get { return this.minutos; }
            set { this.minutos = value; }
        }
        public int _segundos
        {
            get { return this.segundos; }
            set { this.segundos = value; }
        }
        // print(): mostrará la hora(07:03:21).
        public void print()
        {
            Console.WriteLine($"{hora:D2}:{minutos:D2}:{segundos:D2}");
        }
        // aSegundos(): devolverá el número de segundos transcurridos desde la medianoche.
        public int aSegundos()
        {
            int diferenciaSegundo = this.hora* 60*60;
            return diferenciaSegundo;


            //otra sugerencia de CHATgpt
            //return cantSegundos(this.hora, this.minutos, this.segundos);
        }
        // deSegundos(int): hará que la hora sea la correspondiente a haber transcurrido
        //desde la medianoche los segundos que se indiquen. 
        public void deSegundos(int seg) 
        {
            if(seg>60)
            {
                int min = seg / 60;
                int newsegundos = seg % 60;
                if (min > 60)
                {
                    int newhora = min/60;
                    this.hora = newhora;
                }
                this.minutos = min;
                this.segundos = newsegundos;
            }
            else
            {
                this.hora = 00;
                this.minutos = 00;
                this.segundos = seg;
            }
        }

        // segundosDesde(Hora): devolverá el número de segundos entre la hora y la
        //proporcionada.
        public int segundosDesde(Hora newhora)
        {
            int segundosDeHoraOriginal = cantSegundos(this.hora, this.minutos, this.segundos);
            int segundosDeHoraPasada = cantSegundos(newhora.hora, newhora.minutos, newhora.segundos);
            if (segundosDeHoraOriginal < segundosDeHoraPasada)
            {
                //int bandera = segundosDeHoraOriginal;
                //segundosDeHoraOriginal = segundosDeHoraPasada;
                //segundosDeHoraPasada=bandera;

                //otra forma mas simple segun CHATGPT
                (segundosDeHoraOriginal, segundosDeHoraPasada) = (segundosDeHoraPasada, segundosDeHoraOriginal);

            }
            int difeSegundos = segundosDeHoraOriginal - segundosDeHoraPasada;
            return difeSegundos;

        }

        public int cantSegundos(int hora,int min, int seg)
        {
            int newsegundos = min *60;
            int newhora = (hora * 60) * 60;
            int totalSegundos = newhora + newsegundos;
            return totalSegundos;
            
        }

        // siguiente(): pasará al segundo siguiente. 
        public void siguiente()
        {
            this.segundos += 1;
            valida();
        }
        // anterior(): pasará al segundo anterior. 
        public void anterior()
        {
            this.segundos -= 1;
            valida();
        }
        // copia(): devolverá un clon de la hora. 
        public Hora copia()
        {
            //Hora miCopia = new Hora();
            //miCopia.hora = this.hora;
            //miCopia.minutos = this.minutos;
            //miCopia.segundos = this.segundos;
            //return miCopia;

            //segun chatGPT
            return new Hora(hora, minutos, segundos);

        }
        // igualQue(Hora): indica si la hora es la misma que la proporcionada. 
        public bool igualQue(Hora hora)
        {
            if(hora.hora == this.hora && hora.minutos == this.minutos && hora.segundos == this.segundos)
                return true;
            else 
                return false; 

            //mejor forma segun chatGPT
            //bool sonIguales = this.hora == hora.hora && this.minutos == hora.minutos && this.segundos == hora.segundos;
            //Console.WriteLine(sonIguales ? "Las horas son iguales" : "Las horas son distintas");

        }

        // menorQue(Hora): indica si la hora es anterior a la proporcionada.
        public bool menorQue(Hora hora)
        {
            if (hora.hora > this.hora)
            {
                return true;
            }
            else
            {
                if(hora.minutos > this.minutos)
                {
                    Console.WriteLine("la hora es anterior a la proporcionada");
                    return true;
                }
                else
                {
                    if (hora.segundos > this.segundos)
                    {
                        Console.WriteLine("la hora es anterior a la proporcionada");
                        return true; 
                    }
                }
                return false;
            }
        }
        // mayorQue(Hora): indica si la hora es posterior a la proporcionada.
        public bool mayorQue(Hora hora)
        {
            if (hora.hora < this.hora)
            {
                Console.WriteLine("la hora es posterior a la proporcionada");
                return true;
            }
            else
            {
                if (hora.minutos < this.minutos)
                {
                    Console.WriteLine("la hora es posterior a la proporcionada");
                    return true;
                }
                else
                {
                    if (hora.segundos < this.segundos)
                    {
                        Console.WriteLine("la hora es posterior a la proporcionada");
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
