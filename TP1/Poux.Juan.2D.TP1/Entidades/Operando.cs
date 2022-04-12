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
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        //propiedad que trabaja con tipo string
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
            get
            {
                return this.numero.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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

        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "";
            if (int.TryParse(numero, out int numeroEntero))
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

        private double ValidarOperando(string strNumero)
        {
            if (!double.TryParse(strNumero, out double retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

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
