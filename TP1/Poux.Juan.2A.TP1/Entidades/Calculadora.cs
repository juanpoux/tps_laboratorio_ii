namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que el operado recibido sea '+', '-', '*' o '/', de lo contrario devuelve '+'
        /// </summary>
        /// <param name="operador">operador en formato char</param>
        /// <returns>retorna el operador que recibe o '+' si no fue validado</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '*' && operador != '-' && operador != '/')
            {
                operador = '+';
            }
            return operador;
        }

        /// <summary>
        /// Realiza la operacion correspondiente segun el operador que recibe
        /// </summary>
        /// <param name="num1">Objeto que va a ser el primer operando</param>
        /// <param name="num2">Objeto que va a ser el primer operando</param>
        /// <param name="operador">Operador en formato char</param>
        /// <returns>retorna el resultado del calculo que realizo</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno;
            char op = ValidarOperador(operador);
            switch (op)
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
