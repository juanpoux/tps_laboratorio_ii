using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = double.Parse(strNumero);
            //double.TryParse(strNumero, out this.numero);
        }

        private double Numero
        {
            set
            {
                this.numero = ValidarOperando(value.ToString());
            }
        }

        private bool EsBinario(string binario)
        {
            bool retorno = true;
            char[] charArray = binario.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] != '1' || charArray[i] != '0')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static double BinarioDecimal(string binario)
        {
            //Operando.EsBinario(binario);
            char[] charBinario = binario.ToCharArray();
            Array.Reverse(charBinario);
            int retorno = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    retorno += (int)Math.Pow(2, i);
                }
            }
            return retorno;
        }

        private double ValidarOperando(string strNumero)
        {
            double retorno;

            if(!double.TryParse(strNumero, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }
    }
}
