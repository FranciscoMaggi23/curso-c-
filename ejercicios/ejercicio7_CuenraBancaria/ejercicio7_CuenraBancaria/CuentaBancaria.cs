using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7_CuenraBancaria
{
    class CuentaBancaria
    {
        private static long ultimoNumeroCuenta = 100000;
        //atributos, Accedentes y mutadores.Para el número de cuenta no habrá mutador. 

        private long numeroDeCuenta { get; }
        private long dni { get; set; }
        private double saldoActual { get; set; }
        private double interesAnual { get; set; }

        //constructor por defecto
        public CuentaBancaria()
        {
            numeroDeCuenta = ++ultimoNumeroCuenta;
            dni = 0;
            saldoActual = 0.0;
            interesAnual = 0.0;

        }
        //constructor con DNI, saldo e interés
        public CuentaBancaria( long dni, double saldoActual, double interes)
        {
            numeroDeCuenta = ++ultimoNumeroCuenta;
            this.dni = dni;
            this.saldoActual = saldoActual;
            interesAnual = interes;
        }
        // actualizarSaldo(): actualizará el saldo de la cuenta aplicándole el interés diario
        //(interés anual dividido entre 365 aplicado al saldo actual). 
        public void actualizarSaldo()
        {
            double interesDiario = interesAnual / 365;
            saldoActual+=saldoActual * interesDiario;
        }
        // ingresar(double): permitirá ingresar una cantidad en la cuenta.
        public void ingresar(double monto)
        {
            saldoActual += monto;
            //Cuando se utiliza :C, el valor numérico se formatea con el símbolo de la moneda y se ajusta según la configuración regional.
            Console.WriteLine($"Se ingresaron {monto:C} a la cuenta. Nuevo saldo: {saldoActual:C}");

        }
        // retirar(double): permitirá sacar una cantidad de la cuenta(si hay saldo).
        public void retirar(double monto)
        {
            if (saldoActual != 0 && saldoActual>=monto)
            {
                saldoActual -= monto;
                Console.WriteLine($"Se retiraron {monto:C} de la cuenta. Nuevo saldo: {saldoActual:C}");

            }
            else
            {
                Console.WriteLine("usted no tiene ese monto \n");
            }
        }
        // Método que nos permita mostrar todos los datos de la cuenta.
        public void imprimir()
        {
            Console.WriteLine($"numero de cuenta {numeroDeCuenta};\n saldo actual {saldoActual};\n interes anual {interesAnual}; ");
        }




    }


}
