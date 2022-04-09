using System;
using Entidades;

namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando("3");
            Operando num2 = new Operando(5);

            num1.Numero = "2";
            num2.Numero = "45";

            double r = Calculadora.Operar(num1, num2, '*');

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
