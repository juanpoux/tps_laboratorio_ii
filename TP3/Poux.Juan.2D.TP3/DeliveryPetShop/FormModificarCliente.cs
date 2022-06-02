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
        public Cliente cliente;
        public FormModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (base.ValidarCamposCompletos())
            {
                this.cliente.Direccion = this.txtDireccion.Text;
                this.cliente.Nombre = this.txtNombre.Text;
                this.cliente.Telefono = this.txtTelefono.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            this.txtDireccion.Text = this.cliente.Direccion;
            this.txtNombre.Text = this.cliente.Nombre;
            this.txtTelefono.Text = this.cliente.Telefono;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
