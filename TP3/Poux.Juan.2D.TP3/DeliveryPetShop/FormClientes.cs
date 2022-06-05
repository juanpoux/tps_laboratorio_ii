﻿using DeliveryPetShop;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace PruebaTp3Form
{
    public partial class FormClientes : Form
    {
        public List<Cliente> listaClientes;
        public List<Pedido> listaPedidos;
        public Pedido pedido;
        public Cliente cliente;

        public FormClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormClientes(List<Cliente> listaClientes, List<Pedido> listaPedidos) : this()
        {
            this.listaClientes = listaClientes;
            this.listaPedidos = listaPedidos;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.Cargar();
            this.EscribirClientes();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                FormVentas formVentas = new FormVentas((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                formVentas.ShowDialog();
                switch (formVentas.DialogResult)
                {
                    case DialogResult.OK:
                        //aca recupero el pedido de ventas
                        this.DialogResult = DialogResult.OK;
                        this.pedido = formVentas.pedido;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                FormModificarCliente formModificarCliente = new FormModificarCliente((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                formModificarCliente.ShowDialog();
                if (formModificarCliente.DialogResult == DialogResult.OK)
                {
                    this.dgvClientes.CurrentRow.SetValues(formModificarCliente.clienteAux.Nombre, formModificarCliente.clienteAux.Telefono, formModificarCliente.clienteAux.Direccion);
                    this.EscribirClientes();
                }
                this.Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cargar()
        {
            List<Cliente> listita = new List<Cliente>();
            foreach (Cliente item in this.listaClientes)
            {
                if (item.Activo)
                {
                    listita.Add(item);
                }
            }
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = listita;
            this.OrdenarDGV();
        }

        private void OrdenarDGV()
        {
            this.dgvClientes.Columns[3].Visible = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
            if (formNuevoCliente.DialogResult == DialogResult.OK)
            {
                this.listaClientes.Add(formNuevoCliente.cliente);
                this.Cargar();
                this.EscribirClientes();
            }
        }

        private void EscribirClientes()
        {
            try
            {
                SerializacionConJson<List<Cliente>> serializacionConJson = new SerializacionConJson<List<Cliente>>();
                serializacionConJson.Escribir(this.listaClientes, "ListaClientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar escribir lista de clientes\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                string mensaje = ((Cliente)this.dgvClientes.CurrentRow.DataBoundItem).MostrarCliente() + "\n";
                bool bandera = false;
                foreach (Pedido item in this.listaPedidos)
                {
                    if (item == (Cliente)this.dgvClientes.CurrentRow.DataBoundItem)
                    {
                        mensaje += item.MostrarPedido();
                        bandera = true;
                    }
                }
                if (!bandera)
                {
                    mensaje += "***** No se encuentran pedidos registrados *****";
                }
                FormMostrador formMostrador = new FormMostrador(mensaje);
                formMostrador.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void txtBuscarPorDireccion_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorDireccion.Text is not null && this.txtBuscarPorDireccion.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listita = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Direccion.ToLower().StartsWith(this.txtBuscarPorDireccion.Text.ToLower()))
                    {
                        listita.Add(item);
                    }
                }
                this.dgvClientes.DataSource = listita;
            }
            else
            {
                this.Cargar();
            }
        }

        private void txtBuscarPorTelefono_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorTelefono.Text is not null && this.txtBuscarPorTelefono.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listita = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Telefono.ToLower().StartsWith(this.txtBuscarPorTelefono.Text.ToLower()))
                    {
                        listita.Add(item);
                    }
                }
                this.dgvClientes.DataSource = listita;
            }
            else
            {
                this.Cargar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorNombre.Text is not null && this.txtBuscarPorNombre.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listita = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Nombre.ToLower().StartsWith(this.txtBuscarPorNombre.Text.ToLower()))
                    {
                        listita.Add(item);

                    }
                }
                this.dgvClientes.DataSource = listita;
            }
            else
            {
                this.Cargar();
            }
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Seguro desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.cliente = ((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                    cliente.Activo = false;
                    this.EscribirClientes();
                }
                this.Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
