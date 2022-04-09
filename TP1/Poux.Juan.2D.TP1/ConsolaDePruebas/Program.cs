using System;
using Entidades;

namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando("5");
            Operando num2 = new Operando(0);

            double r = Calculadora.Operar(num1, num2, '/');

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
