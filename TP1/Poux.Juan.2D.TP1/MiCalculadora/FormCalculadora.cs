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

            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
        }

        private void formCalculadora_Load(object sender, EventArgs e)
        {
            //this.cmbOperador.Items.Clear();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = this.cmbOperador.Text;
            this.lblResultado.Text = this.cmbOperador.Text;
            this.lstOperaciones.Items.Add(this.lblResultado.Text);

            /*if (this.cmbOperador.SelectedIndex == 1)
            {
                this.cmbOperador.Items.Add("$");
            }*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void formCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult resultado = MessageBox.Show("me cierro?", "Salir", MessageBoxButtons.YesNo);
            //if (resultado == DialogResult.Yes)
            //{
            //    e.Cancel = false; //Cancela el evento "Cancelar cierre" o sea, SALE;
            //}
            //else
            //{
            //    e.Cancel = true; //Confirma el evento "Cancelar cierre" o sea, NO sale;
            //}
        }

        private void formCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chauchi");
        }
    }
}
