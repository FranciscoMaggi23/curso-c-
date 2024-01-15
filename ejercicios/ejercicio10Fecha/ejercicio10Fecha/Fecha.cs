using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10Fecha
{
    internal class Fecha
    {
        //atributos
        private int dia;
        private int mes;
        public int anio;

        // Constructor predeterminado con el 1 - 1 - 1900 como fecha por defecto. 
        public Fecha()
        {
            dia = 1;
            mes= 1;
            anio = 1900;
        }
        // Constructor parametrizado con día, mes y año. 
        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;     
            this.mes = mes; 
            this.anio = anio;
        }
        // valida(): comprobará si la fecha es correcta(entre el 1 - 1 - 1900 y el 31 - 12 - 2050);
        //            si el día no es correcto, lo pondrá a 1; si el mes no es correcto, lo pondrá a 1;
        //            y si el año no es correcto, lo pondrá a 1900.Será un método auxiliar(privado).
        public void valida()
        {
            if (dia < 1 || dia > 31) dia= 1;
            if (mes < 1 || mes > 12) mes = 1;
            if (anio < 1900 || anio > 2050) anio = 1900;


        }

        // leer(): pedirá al usuario el día(1 a 31), el mes(1 a 12) y el año(1900 a 2050).
        public void leer()
        {
            Console.Write("Ingrese día (1-31): ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese mes (1-12): ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año (1900-2050): ");
            anio = int.Parse(Console.ReadLine());

            valida();

        }
        // bisiesto(): indicará si el año de la fecha es bisiesto o no.
        public bool bisiesto()
        {
            return (anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0));
        }
        // diasMes(int): devolverá el número de días del mes que se le indique
        //(para el año de la fecha).
        public int diasMes(int mes)
        {
            int[] diasPorMes = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (mes == 2 && bisiesto()) return 29;
            return diasPorMes[mes];
        }

        // Accedentes y mutadores.
        public int Dia
        {
            get { return dia; }
            set { dia = value; valida(); }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; valida(); }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; valida(); }
        }
        // corta(): mostrará la fecha en formato corto(02 - 09 - 2003). 
        public void corta()
        {
            //La notación ${dia:D2} indica que el valor de dia debe formatearse como un número entero (D) con al menos dos dígitos (2).
            //Esto garantiza que, independientemente del valor actual de dia, se mostrará con al menos dos dígitos, y si es necesario, se agregarán ceros a la izquierda.
            Console.WriteLine($"{dia:D2}-{mes:D2}-{anio}");
        }
        // diasTranscurridos(): devolverá el número de días transcurridos
        //desde el 1 - 1 - 1900 hasta la fecha.
        public int diasTranscurridos()
        {
            int dias = dia - 1;
            //sumas segun los dias de tal mes
            for (int i = 1; i < mes; i++)
            {
                dias += diasMes(i);
            }
            // operador ternario, si es V +366, si es F +365
            for (int i = 1900; i < anio; i++)
            {
                dias += bisiesto() ? 366 : 365;
            }

            return dias;
        }
        // diaSemana(): devolverá el día de la semana de la fecha
        //(0 para domingo, ..., 6 para sábado).El 1 - 1 - 1900 fue domingo. 
        public int diaSemana()
        {
            return (diasTranscurridos()) % 7;
        }
        // larga(): mostrará la fecha en formato largo, empezando por el día de la semana
        //(martes 2 de septiembre de 2003).
        public void larga()
        {
            string[] dias = { "domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado"  };
            Console.WriteLine($"{dias[diaSemana()]} {dia} de {nombreMes()} de {anio}");
        }

        //metodo axiliar para larga()
        public string nombreMes()
        {
            string[] meses = { "", "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            return meses[mes];
        }

        // fechaTras(long): hará que la fecha sea la correspondiente a haber transcurrido
        //los días que se indiquen desde el 1 - 1 - 1900.
        public void fechaTras(long dias)
        {
            int totalDias = diasTranscurridos() + (int)dias;
            int anio = 1900;

            while (totalDias > (bisiesto() ? 366 : 365))
            {
                totalDias -= bisiesto() ? 366 : 365;
                anio++;
            }

            int[] diasPorMes = new int[] { 0, 31, (bisiesto() ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes = 1;

            while (totalDias > diasPorMes[mes])
            {
                totalDias -= diasPorMes[mes];
                mes++;
            }

            int dia = totalDias;

            // Asigna los valores calculados a los atributos dia, mes y anio
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;

            // Asegúrate de llamar a valida() después de asignar los valores
            valida();
        }

        // diasEntre(Fecha): devolverá el número de días entre la fecha y la proporcionada.
        public int diasEntre(Fecha otraFecha)
        {
            long diferencia= otraFecha.diasTranscurridos() - diasTranscurridos();
            return Math.Abs((int)diferencia);

        }

        // siguiente(): pasará al día siguiente. 
        public void siguiente()
        {
            fechaTras(1);

        }
        // anterior(): pasará al día anterior. 
        public void anterior()
        {
            fechaTras(-1);

        }
        // copia(): devolverá un clon de la fecha.
        public Fecha copia()
        {
            return new Fecha(dia, mes, anio);
        }

        // igualQue(Fecha): indica si la fecha es la misma que la proporcionada. 
        public bool igualQue(Fecha fecha)
        {
            if(fecha.dia == dia && fecha.mes == mes && fecha.anio == anio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // menorQue(Fecha): indica si la fecha es anterior a la proporcionada.
        public bool menorQue(Fecha fecha)
        {
            //if ((fecha.dia >= dia || fecha.mes >= mes) && fecha.anio >= anio)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return diasTranscurridos() < fecha.diasTranscurridos();
        }
        // mayorQue(Fecha): indica si la fecha es posterior a la proporcionada.

        public bool mayorQue(Fecha otraFecha)
        {
            // Compara si la fecha actual es posterior a otra fecha
            return diasTranscurridos() > otraFecha.diasTranscurridos();
        }


    }
}
