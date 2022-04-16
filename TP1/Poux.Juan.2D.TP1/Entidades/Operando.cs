using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que asigna el double que recibe por parametro al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asigna el string que recibe por parametro a la propiedad Numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Propiedad que trabaja con tipo string y asigna un dato validado al atributo numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Valida que la cadena que recibe este compuesta solamente por caracteres '0' y/o '1'
        /// </summary>
        /// <param name="binario"> Numero binario en formato string </param>
        /// <returns> retorna true si esta compuesto solo por '0' y '1', false si encuentra otro caracter </returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] charArray = binario.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != '1' && charArray[i] != '0')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte el numero binario a numero decimal
        /// </summary>
        /// <param name="binario"> numero binario en formato string </param>
        /// <returns> retorna el numero convertido en formato string </returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            if (EsBinario(binario))
            {
                char[] charBinario = binario.ToCharArray();
                Array.Reverse(charBinario);
                int conversion = 0;

                for (int i = 0; i < charBinario.Length; i++)
                {
                    if (charBinario[i] == '1')
                    {
                        conversion += (int)Math.Pow(2, i);
                    }
                }
                retorno = conversion.ToString();
            }
            return retorno;
        }

        /// <summary>
        /// Convierte el numero decimal en binario
        /// </summary>
        /// <param name="numero"> numero decimal en formato double</param>
        /// <returns> numero binario en formato string </returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Convierte el numero decimal en binario
        /// </summary>
        /// <param name="numero"> numero decimal en formato string </param>
        /// <returns> numero binario en formato string </returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "";
            if (numero == "0")
            {
                retorno = "0";
            }
            if (int.TryParse(numero, out int numeroEntero) && numeroEntero > -1)
            {
                int resto;
                for (int i = numeroEntero; numeroEntero > 0; i--)
                {
                    resto = numeroEntero % 2;
                    retorno = resto.ToString() + retorno;
                    numeroEntero /= 2;
                }
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba que el valor recibido sea numérico, de lo contrario retorna 0
        /// </summary>
        /// <param name="strNumero"> numero en formato string </param>
        /// <returns> retorna el numero en formato double o 0 si no pudo validarlo </returns>
        private double ValidarOperando(string strNumero)
        {
            if (!double.TryParse(strNumero, out double retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

        /// <summary>
        /// Recibe 2 objetos Operando, accede al atributo numero y los suma
        /// </summary>
        /// <param name="n1"> objeto que va a ser el primer operando </param>
        /// <param name="n2"> objeto que va a ser el segundo operando </param>
        /// <returns> retorna el resultado de la suma </returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos Operando, accede al atributo numero y los resta
        /// </summary>
        /// <param name="n1"> objeto que va a ser el primer operando </param>
        /// <param name="n2"> objeto que va a ser el segundo operando </param>
        /// <returns> retorna el resultado de la resta </returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos Operando, accede al atributo numero y los multiplica
        /// </summary>
        /// <param name="n1"> objeto que va a ser el primer operando </param>
        /// <param name="n2"> objeto que va a ser el primer operando </param>
        /// <returns> retorna el resultado de la multiplicacion </returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Recibe 2 objetos Operando, accede al atributo numero y los divide
        /// </summary>
        /// <param name="n1"> objeto que va a ser el primer operando </param>
        /// <param name="n2"> objeto que va a ser el primer operando </param>
        /// <returns> retorna el resultado de la division si pudo. Si el segundo opernado es 0, retorna double.MinValue </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }
    }
}
