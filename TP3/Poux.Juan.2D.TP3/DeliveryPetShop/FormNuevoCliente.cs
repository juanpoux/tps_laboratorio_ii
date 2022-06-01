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
        FormClientes formClientes;
        Cliente cliente;
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        public FormNuevoCliente(FormClientes formClientes) : this()
        {
            this.formClientes = formClientes;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(this.txtTelefono.Text, this.txtNombre.Text, this.txtDireccion.Text);
            formClientes.listBox1.Items.Add(cliente);
            formClientes.listaClientes.Add(cliente);
            this.Close();
        }
    }
}
