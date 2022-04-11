using System;
using System.Windows.Forms;
using Entidades;
using System.Collections.Generic;

namespace MiCalculadora
{
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void formCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operando1 = this.txtNumero1.Text;
            string operando2 = this.txtNumero2.Text;
            string operador = this.cmbOperador.Text;
            double resultado = Operar(operando1, operando2, operador);

            double.TryParse(operando1, out double operadorNum1);
            double.TryParse(operando2, out double operadorNum2);
            if (string.IsNullOrWhiteSpace(operador))
            {
                operador = "+";
            }
            string textoResultado = $"{operadorNum1} {operador} {operadorNum2} = {resultado}";

            this.lblResultado.Text = resultado.ToString();
            this.lstOperaciones.Items.Add(textoResultado);
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char.TryParse(operador, out char operadorChar);

            retorno = Calculadora.Operar(operando1, operando2, operadorChar);

            return retorno;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void formCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult resultado = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (resultado == DialogResult.Yes)
        //    {
        //        e.Cancel = false; //Cancela el evento "Cancelar cierre" o sea, SALE;
        //    }
        //    else
        //    {
        //        e.Cancel = true; //Confirma el evento "Cancelar cierre" o sea, NO sale;
        //    }
        //}

        private void formCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chauchi");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
        }

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
