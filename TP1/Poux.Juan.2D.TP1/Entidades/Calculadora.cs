namespace Entidades
{
    public class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador != '*' && operador != '-' && operador != '/')
            {
                operador = '+';
            }
            return operador;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno;

            switch (operador)
            {
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    retorno = num1 / num2;
                    break;
                default:
                    retorno = num1 + num2;
                    break;
            }
            return retorno;
        }
    }
}
