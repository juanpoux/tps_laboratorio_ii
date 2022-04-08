namespace Entidades
{
    class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = operador;
            switch (operador)
            {
                case '+':
                    retorno = '+';
                    break;
                case '-':
                    retorno = '-';
                    break;
                case '*':
                    retorno = '*';
                    break;
                case '/':
                    retorno = '/';
                    break;
                default:
                    retorno = '+';
                    break;
            }
            return retorno;
        }

        public double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;

            return retorno;
        }
    }
}
