using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
                //tengo que recibir el pedido y agregarlo a la lista
                this.listaPedidos.Add(formClientes.pedido);
                this.listBox1.Items.Add(formClientes.pedido);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.CargarListaClientes();
            this.pedido = new Pedido(this.listaClientes[0], false, DateTime.Now);
            this.listBox1.Items.Add(pedido);
            this.listaPedidos.Add(pedido);
            this.pedido = new Pedido(this.listaClientes[1], true, DateTime.Now);
            this.listBox1.Items.Add(pedido);
            this.listaPedidos.Add(pedido);
            this.pedido = new Pedido(this.listaClientes[2], false, DateTime.Now);
            this.listBox1.Items.Add(pedido);
            this.listaPedidos.Add(pedido);
            this.pedido = new Pedido(this.listaClientes[3], true, DateTime.Now);
            this.listBox1.Items.Add(pedido);
            this.listaPedidos.Add(pedido);
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                string mensaje = this.listaPedidos[index].cliente.MostrarCliente() + this.listaPedidos[index].MostrarPedido();
                MessageBox.Show(mensaje);
                Clipboard.SetText(mensaje);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeerClientes()
        {

        }

        private void CargarListaClientes()
        {
            this.listaClientes = new()
            {
                new Cliente("1555500058", "Juan", "Saavedra 352"),
                new Cliente("1555500063", "Jose", "Saavedra 45677"),
                new Cliente("1566005555", "Eze", "Laprida 166"),
                new Cliente("42489055", "Thiago", "Gorriti 588"),
                new Cliente("42425544", "Carlos", "Loria 266"),
                new Cliente("1188559445", "Camila", "Colombres 1500"),
                new Cliente("1166589555", "Pedro", "Sarmiento 8444"),
                new Cliente("1188469478", "Olivia", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Alberto", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Sofia", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Trinidad", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Javier", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Tristan", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Felipe", "Hipolito Yrigoyen 2669"),
                new Cliente("1188469478", "Ricardo", "Hipolito Yrigoyen 2669"),
                new Cliente("41654814", "Juliana", "Vieytes 2344")
            };
        }
    }
}
