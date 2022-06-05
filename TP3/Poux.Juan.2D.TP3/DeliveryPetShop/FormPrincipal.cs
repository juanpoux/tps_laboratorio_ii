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
        public List<Pedido> listaPedidosTotales;

        public FormPrincipal()
        {
            InitializeComponent();
            this.listaPedidosTotales = new List<Pedido>();
            this.listaClientes = new List<Cliente>();
        }

        private void btnRealizarPedidoNuevo_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(this.listaClientes, this.listaPedidosTotales);
            formClientes.ShowDialog();
            if (formClientes.DialogResult == DialogResult.OK)
            {
                this.listaPedidosTotales.Add(formClientes.pedido);
                string mensaje = formClientes.pedido.Cliente.MostrarCliente();
                mensaje += formClientes.pedido.MostrarPedido();
                Clipboard.SetText(mensaje);
                mensaje += "\n\n***MENSAJE COPIADO AL PORTAPAPELES***";
                FormMostrador formMostrador = new FormMostrador(mensaje);
                formMostrador.Show();
                string nombreArchivo = $"{formClientes.pedido.NombreCliente.Replace(' ', '-')}-{formClientes.pedido.DiaDeEntrega.ToShortDateString().Replace('/', '-')}";
                this.EscribirArchivoTexto(nombreArchivo, mensaje);
            }
            this.Cargar();
        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.LeerClientes();
            this.LeerPedidos();
            this.dgvPedidosTotales.AutoGenerateColumns = false;
            this.Cargar();
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidosTotales.SelectedRows.Count > 0)
            {
                try
                {
                    string mensaje = ((Pedido)this.dgvPedidosTotales.CurrentRow.DataBoundItem).Cliente.MostrarCliente();
                    mensaje += ((Pedido)this.dgvPedidosTotales.CurrentRow.DataBoundItem).MostrarPedido();

                    FormMostrador formMostrador = new FormMostrador(mensaje);
                    formMostrador.Show();
                    Clipboard.SetText(mensaje);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe seleccionar un pedido para ver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido para ver", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.EscribirPedidos();
            this.Close();
        }

        private void LeerClientes()
        {
            try
            {
                SerializacionConJson<List<Cliente>> serializacionConJson = new SerializacionConJson<List<Cliente>>();
                this.listaClientes = serializacionConJson.Leer("ListaClientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer lista de clientes\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LeerPedidos()
        {
            try
            {
                SerializacionConJson<List<Pedido>> serializacionConJson = new SerializacionConJson<List<Pedido>>();
                this.listaPedidosTotales = serializacionConJson.Leer("ListaPedidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar leer la lista de pedidos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EscribirPedidos()
        {
            try
            {
                SerializacionConJson<List<Pedido>> serializacionConJson = new SerializacionConJson<List<Pedido>>();
                serializacionConJson.Escribir(this.listaPedidosTotales, "ListaPedidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar escribir la lista de pedidos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EscribirArchivoTexto(string nombre, string datos)
        {
            try
            {
                SerializarArchivoTexto.Escribir(nombre, datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar escribir archivo de texto\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cargar()
        {
            this.dgvPedidosTotales.AutoGenerateColumns = true;
            List<Pedido> listita = new List<Pedido>();
            foreach (Pedido item in this.listaPedidosTotales)
            {
                listita.Add(item);
            }
            this.dgvPedidosTotales.DataSource = null;
            this.dgvPedidosTotales.DataSource = listita;
            if (listita.Count > 0)
            {
                this.dgvPedidosTotales.ClearSelection();
                this.dgvPedidosTotales.TabIndex = 0;
            }
            this.OrdenarDGV();
        }

        private void OrdenarDGV()
        {
            this.dgvPedidosTotales.Columns[0].Visible = false;
            this.dgvPedidosTotales.Columns[7].Visible = false;
            this.dgvPedidosTotales.Columns[1].Width = 150;
            this.dgvPedidosTotales.Columns[2].Width = 200;
        }

    }
}
