using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7_CuenraBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Crea una clase Cuenta(bancaria) con atributos para el número de cuenta(un entero
            //largo), el DNI del cliente(otro entero largo), el saldo actual y el interés anual que se
            //aplica a la cuenta(porcentaje).Define en la clase los siguientes métodos: 
            //                Constructor por defecto y constructor con DNI, saldo e interés
            // Accedentes y mutadores.Para el número de cuenta no habrá mutador. 
            // actualizarSaldo(): actualizará el saldo de la cuenta aplicándole el interés diario
            //(interés anual dividido entre 365 aplicado al saldo actual). 
            // ingresar(double): permitirá ingresar una cantidad en la cuenta.
            // retirar(double): permitirá sacar una cantidad de la cuenta(si hay saldo).
            // Método que nos permita mostrar todos los datos de la cuenta.
            //El número de cuenta se asignará de forma correlativa a partir de 100001, asignando
            //el siguiente número al último asignado.

            CuentaBancaria micuenta = new CuentaBancaria(43258438, 10000, 700);
            micuenta.imprimir();

            Console.WriteLine("\n ingreso dinero");
            micuenta.ingresar(500);
            micuenta.actualizarSaldo();
            micuenta.imprimir();


            Console.WriteLine("\n retiro dinero");
            micuenta.retirar(5000);

            micuenta.imprimir();


        }
    }
}
