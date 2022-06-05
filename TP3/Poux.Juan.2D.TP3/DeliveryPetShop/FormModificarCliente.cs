using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTp3Form
{
    public partial class FormModificarCliente : FormNuevoCliente
    {
        public Cliente clienteAux;
        public FormModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.clienteAux = cliente;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (base.ValidarCamposCompletos())
            {
                this.clienteAux.Direccion = this.txtDireccion.Text;
                this.clienteAux.Nombre = this.txtNombre.Text;
                this.clienteAux.Telefono = this.txtTelefono.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            this.txtDireccion.Text = this.clienteAux.Direccion;
            this.txtNombre.Text = this.clienteAux.Nombre;
            this.txtTelefono.Text = this.clienteAux.Telefono;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
