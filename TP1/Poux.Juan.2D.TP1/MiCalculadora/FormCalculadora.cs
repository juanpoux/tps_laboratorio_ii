using System;
using System.Windows.Forms;
using Entidades;
using System.Collections.Generic;

namespace MiCalculadora
{
    public partial class formCalculadora : Form
    {
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public formCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los operadores al cmbOperador y llama al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            Limpiar();
        }

        /// <summary>
        /// Al hacer click en btnOperar llama a realizar los calculos y muesta los resultados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operando1 = this.txtNumero1.Text.Replace(".", ",");
            string operando2 = this.txtNumero2.Text.Replace(".", ",");
            string operador = this.cmbOperador.Text;
            double resultado = Operar(operando1, operando2, operador);

            double.TryParse(operando1, out double operadorNum1);
            double.TryParse(operando2, out double operadorNum2);
            string textoResultado;
            if (string.IsNullOrWhiteSpace(operador))
            {
                operador = "+";
            }
            if (resultado == double.MinValue)
            {
                textoResultado = "Valor invalido";
                this.lblResultado.Text = textoResultado;
            }
            else
            {
                textoResultado = $"{operadorNum1} {operador} {operadorNum2} = {resultado}";
                this.lblResultado.Text = resultado.ToString();
            }
            this.lstOperaciones.Items.Add(textoResultado);
        }

        /// <summary>
        /// Realiza la operacion entre los valores y operador elejidos por el usuario
        /// </summary>
        /// <param name="numero1">primer valor en formato string</param>
        /// <param name="numero2">segundo valor en formato string</param>
        /// <param name="operador">operador en formato string</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char.TryParse(operador, out char operadorChar);

            retorno = Calculadora.Operar(operando1, operando2, operadorChar);

            return Math.Round(retorno, 6);
        }

        /// <summary>
        /// Intenta cerrar la aplicacion preguntando si realmente desea cerrar o cancelar el cierre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Comienzo del proceso de cierre de la aplicacion, muestra un mensaje para que el usuario decida si cierra o cancela el cierre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                e.Cancel = false; //Cancela el evento "Cancelar cierre" o sea, SALE;
            }
            else
            {
                e.Cancel = true; //Confirma el evento "Cancelar cierre" o sea, NO sale;
            }
        }

        /// <summary>
        /// El formulario ya es invisible y cerrando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        /// <summary>
        /// Vuelve a los valores establecidos cmbOperador, lblResultado, txtNumero1 y txtNumero2 borrando los valores previos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Establece valores en cmbOperador, lblResultado, txtNumero1 y txtNumero2 borrando los valores previos
        /// </summary>
        private void Limpiar()
        {
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
        }

        /// <summary>
        /// Intenta convertir el resultado en numero binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numeroDecimal = new Operando();
            string textoNumDecimal = this.lblResultado.Text;
            this.lblResultado.Text = numeroDecimal.DecimalBinario(textoNumDecimal);
            string respuesta = $"{textoNumDecimal} (Decimal) = {this.lblResultado.Text} (Binario)";

            if (this.lblResultado.Text == "Valor invalido")
            {
                this.lstOperaciones.Items.Add(this.lblResultado.Text);
            }
            else
            {
                this.lstOperaciones.Items.Add(respuesta);
            }
        }

        /// <summary>
        /// Intenta convertir el resultado si es un numero binario en numero decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numeroBinario = new Operando();
            string textoNumBinario = this.lblResultado.Text;
            this.lblResultado.Text = numeroBinario.BinarioDecimal(textoNumBinario);
            string respuesta = $"{textoNumBinario} (Binario) = {this.lblResultado.Text} (Decimal)";

            if (this.lblResultado.Text == "Valor invalido")
            {
                this.lstOperaciones.Items.Add(this.lblResultado.Text);
            }
            else
            {
                this.lstOperaciones.Items.Add(respuesta);
            }
        }
    }
}
