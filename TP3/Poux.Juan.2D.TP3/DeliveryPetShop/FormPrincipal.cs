using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using DeliveryPetShop;
using Entidades;

namespace PruebaTp3Form
{
    public partial class FormPrincipal : Form
    {
        Pedido pedido;
        public List<Cliente> listaClientes;
        public List<Pedido> listaPedidos;

        public FormPrincipal()
        {
            InitializeComponent();
            this.listaPedidos = new List<Pedido>();
            this.listaClientes = new List<Cliente>();
        }

        private void btnRealizarPedidoNuevo_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(this.listaClientes, this.listaPedidos);
            formClientes.ShowDialog();
            if (formClientes.DialogResult == DialogResult.OK)
            {
                //tengo que recibir el pedido
                this.listaPedidos.Add(formClientes.pedido);
                this.Cargar();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.LeerClientes();
            this.LeerPedidos();
            this.listBox1.DataSource = this.listaPedidos;
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            string mensaje = ((Pedido)this.listBox1.SelectedItem).Cliente.MostrarCliente();
            mensaje += ((Pedido)this.listBox1.SelectedItem).MostrarPedido();
            FormMostrador formMostrador = new FormMostrador(mensaje);
            formMostrador.Show();
            Clipboard.SetText(mensaje);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.EscribirClientes();
            this.EscribirPedidos();
            this.Close();
        }

        private void LeerClientes()
        {
            try
            {
                SerializacionConJson<List<Cliente>> serializacionConJson = new SerializacionConJson<List<Cliente>>();
                this.listaClientes = serializacionConJson.Leer("ListaClientes.json");
            }
            catch (Exception ex)
            {
                //Corregir esto
                MessageBox.Show(ex.GetType().Name);
            }
        }

        private void EscribirClientes()
        {
            try
            {
                SerializacionConJson<List<Cliente>> serializacionConJson = new SerializacionConJson<List<Cliente>>();
                serializacionConJson.Escribir(this.listaClientes, "ListaClientes.json");
            }
            catch (Exception ex)
            {
                //Corregir esto
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerPedidos()
        {
            try
            {
                SerializacionConJson<List<Pedido>> serializacionConJson = new SerializacionConJson<List<Pedido>>();
                this.listaPedidos = serializacionConJson.Leer("ListaPedidos.json");
            }
            catch (Exception ex)
            {
                //Corregir esto
                MessageBox.Show(ex.GetType().Name);
            }
        }

        private void EscribirPedidos()
        {
            try
            {
                SerializacionConJson<List<Pedido>> serializacionConJson = new SerializacionConJson<List<Pedido>>();
                serializacionConJson.Escribir(this.listaPedidos, "ListaPedidos.json");
            }
            catch (Exception ex)
            {
                //Corregir esto
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = this.listaPedidos;
        }

    }
}
