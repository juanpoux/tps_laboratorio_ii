using System;
using Entidades;

namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando(5988);

            //num1.Numero = "1";

            Console.WriteLine(num1.Numero);
        }
    }
}
