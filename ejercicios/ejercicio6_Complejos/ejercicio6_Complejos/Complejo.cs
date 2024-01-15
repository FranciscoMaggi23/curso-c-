using ejercicio6_Complejos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6_Complejos
{
    internal class Complejo
    {
        private double parteReal;
        private double parteImaginaria;

        //constructores:
        public Complejo() 
        {
            parteImaginaria = 0.0;
            parteReal = 0.0;    
        }
        public Complejo(double parteReal, double parteImaginaria)
        {
            this.parteReal = parteReal;
            this.parteImaginaria = parteImaginaria;
        }
        // Accesores
        public double ObtenerParteReal()
        {
            return parteReal;
        }

        public double ObtenerParteImaginaria()
        {
            return parteImaginaria;
        }
        // Mutadores
        public void EstablecerParteReal(double real)
        {
            parteReal = real;
        }

        public void EstablecerParteImaginaria(double imaginaria)
        {
            parteImaginaria = imaginaria;
        }

        //metodos
        public Complejo Sumar(Complejo numComplejo)
        {
            double sumaParteReal = parteReal + numComplejo.ObtenerParteReal();
            double sumaParteImaginaria = parteImaginaria + numComplejo.ObtenerParteImaginaria();
            return new Complejo(sumaParteReal, sumaParteImaginaria);
        }

        public Complejo Restar(Complejo numComplejo)
        {
            double restarParteReal = parteReal - numComplejo.ObtenerParteReal();
            double restarParteImaginaria = parteImaginaria - numComplejo.ObtenerParteImaginaria();
            return new Complejo(restarParteReal, restarParteImaginaria);
        }

        public Complejo Multiplicar(Complejo numComplejo)
        {
            double multiplicarParteReal = parteReal * numComplejo.ObtenerParteReal();
            double multiplicarParteImaginaria = parteImaginaria * numComplejo.ObtenerParteImaginaria();
            return new Complejo(multiplicarParteReal, multiplicarParteImaginaria);
        }

        public Complejo Division(Complejo otroComplejo)
        {
            // Calcula el cuadrado de la parte real e imaginaria del divisor
            double divisor = Math.Pow(otroComplejo.ObtenerParteReal(), 2) + Math.Pow(otroComplejo.ObtenerParteImaginaria(), 2);

            // Calcula las partes real e imaginaria del resultado de la división
            double divisionReal = (parteReal * otroComplejo.ObtenerParteReal() + parteImaginaria * otroComplejo.ObtenerParteImaginaria()) / divisor;
            double divisionImaginaria = (parteImaginaria * otroComplejo.ObtenerParteReal() - parteReal * otroComplejo.ObtenerParteImaginaria()) / divisor;

            // Crea y devuelve un nuevo objeto Complejo con las partes calculadas
            return new Complejo(divisionReal, divisionImaginaria);
        }

        public void Imprimir()
        {
            Console.WriteLine($"parte real {parteReal}, parte imaginaria {parteImaginaria}");
        }

    }
}
//Explicación paso a paso:

//double divisor = Math.Pow(otroComplejo.ObtenerParteReal(), 2) + Math.Pow(otroComplejo.ObtenerParteImaginaria(), 2);: 
//Aquí se está calculando el cuadrado de la parte real e imaginaria del divisor. Math.Pow() es un método que eleva un número 
//    a una potencia específica. En este caso, se utiliza para elevar la parte real e imaginaria del divisor al cuadrado y luego 
//    se suman estos resultados. La variable divisor almacenará el resultado.

//Math.Pow(x, y) eleva x a la potencia y.
//double divisionReal = (parteReal * otroComplejo.ObtenerParteReal() + parteImaginaria * otroComplejo.ObtenerParteImaginaria()) / divisor;: 
//Se calcula la parte real del resultado de la división. La fórmula utilizada es una parte de la fórmula para dividir dos números complejos.

//double divisionImaginaria = (parteImaginaria * otroComplejo.ObtenerParteReal() - parteReal * otroComplejo.ObtenerParteImaginaria()) / divisor;: 
//Se calcula la parte imaginaria del resultado de la división utilizando otra parte de la fórmula.

//return new Complejo(divisionReal, divisionImaginaria);: Se crea un nuevo objeto Complejo con las partes real e imaginaria calculadas y se
//    devuelve como resultado de la función.

//En resumen, Math.Pow() se utiliza para calcular el cuadrado de la parte real e imaginaria del divisor en la fórmula para dividir dos números complejos.