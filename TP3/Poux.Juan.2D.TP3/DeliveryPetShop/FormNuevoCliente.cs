using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PruebaTp3Form
{
    public partial class FormNuevoCliente : Form
    {
        public Cliente cliente;
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposCompletos())
            {
                cliente = new Cliente(this.txtTelefono.Text, this.txtNombre.Text, this.txtDireccion.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in this.txtTelefono.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("Solo se aceptan valores numericos para el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTelefono.Clear();
                    this.txtTelefono.Focus();
                    break;
                }
            }
        }

        protected bool ValidarCamposCompletos()
        {
            bool retorno = true;
            foreach (Control item in this.gbDatosCliente.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text) || string.IsNullOrWhiteSpace(item.Text))
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }
    }
}
