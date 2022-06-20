﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryPetShop;
using Entidades;

namespace PruebaTp3Form
{
    public partial class FormPrincipal : Form
    {
        public List<Cliente> listaClientes;
        public List<Pedido> listaPedidosTotales;
        DelegadoLeerArchivos delegadoLeerArchivos;
        public event EventoEscribirArchivos eventoEscribirArchivos;

        /// <summary>
        /// unico constructor del FormPrincipal donde se instancian las listas, el delegado y el evento
        /// aca uso delegados y eventos
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            this.listaPedidosTotales = new List<Pedido>();
            this.listaClientes = new List<Cliente>();

            delegadoLeerArchivos = LeerPedidos;
            delegadoLeerArchivos += LeerClientes;
            eventoEscribirArchivos += EscribirArchivoTexto;
        }

        /// <summary>
        /// Carga la lista de clientes y pedidos desde archivos y carga el datagrid de pedidos
        /// aca invoco un delegado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            delegadoLeerArchivos.Invoke();
            this.Cargar();
        }

        /// <summary>
        /// Abre el formulario de clientes y si el DialogResult que devuelve es OK agrega el pedido a la lista, copia el pedido al portapapeles, lo muestra en un formulario, crea un archivo .txt con el pedido y sobrescribe el archivo con la lista de pedidos
        /// Aca uso archivos, hilos y eventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizarPedidoNuevo_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(this.listaClientes, this.listaPedidosTotales);
            formClientes.ShowDialog();
            if (formClientes.DialogResult == DialogResult.OK)
            {
                this.listaPedidosTotales.Add(formClientes.pedido);
                string mensaje = formClientes.pedido.Cliente.MostrarCliente();
                mensaje += formClientes.pedido.MostrarPedido();

                string nombreArchivo = $"{formClientes.pedido.NombreCliente.Replace(' ', '-')}-{formClientes.pedido.DiaDeEntrega.ToShortDateString().Replace('/', '-')}";
                this.MostrarMensajeDePedidoYCopiarAlPortapapeles(mensaje);

                Task t = Task.Run(() =>
                {
                    this.EscribirPedidos();
                    eventoEscribirArchivos.Invoke(nombreArchivo, mensaje);
                });
            }
            this.Cargar();
        }

        private void MostrarMensajeDePedidoYCopiarAlPortapapeles(string mensaje)
        {
            Clipboard.SetText(mensaje);
            mensaje += "\n\n***MENSAJE COPIADO AL PORTAPAPELES***";
            FormMostrador formMostrador = new FormMostrador(mensaje);
            formMostrador.Show();
        }


        /// <summary>
        /// Muestra la informacion del pedido seleccionado en un formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidosTotales.SelectedRows.Count > 0)
            {
                try
                {
                    string mensaje = ((Pedido)this.dgvPedidosTotales.CurrentRow.DataBoundItem).Cliente.MostrarCliente();
                    mensaje += ((Pedido)this.dgvPedidosTotales.CurrentRow.DataBoundItem).MostrarPedido();
                    this.MostrarMensajeDePedidoYCopiarAlPortapapeles(mensaje);
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

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga la lista de clientes desde la base de datos
        /// Aca aplico serializacion e hilos
        /// </summary>
        private void LeerClientes()
        {
            Task t = Task.Run(() =>
            {
                try
                {
                    if (ClienteDao.ProbarConexion())
                    {
                        this.listaClientes = ClienteDao.Leer();
                    }
                }
                catch (BaseDeDatosException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar leer lista de clientes\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            );
        }

        /// <summary>
        /// Carga la lista de pedidos desde el archivo JSON
        /// Aca aplico serializacion
        /// </summary>
        private void LeerPedidos()
        {
            try
            {
                SerializacionConJson<List<Pedido>> serializacionConJson = new SerializacionConJson<List<Pedido>>();
                this.listaPedidosTotales = serializacionConJson.Leer("ListaPedidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha encontrado una lista de pedidos en la ubicacion\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// De no existir crea un archivo JSON con los datos de los pedidos cargados en la lista
        /// Aca aplico serializacion
        /// </summary>
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

        /// <summary>
        /// Crea y escribe en un archivo .txt la informacion del pedido
        /// Aca aplico archivos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="datos"></param>
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

        /// <summary>
        /// limpio el datagrid poniendolo en null y luego lo cargo con la lista de pedidos
        /// </summary>
        private void Cargar()
        {
            this.dgvPedidosTotales.AutoGenerateColumns = true;
            this.dgvPedidosTotales.DataSource = null;
            this.OrdenarListaPorFecha();
            this.dgvPedidosTotales.DataSource = this.listaPedidosTotales;
            this.OrdenarDGV();
        }

        /// <summary>
        /// Ordena la lista por fecha, para que los pedidos mas antiguos vayan quedando abajo y los mas nuevos y futuros mas arriba
        /// </summary>
        private void OrdenarListaPorFecha()
        {
            if (this.listaPedidosTotales.Count > 0)
            {
                this.listaPedidosTotales.Sort(Pedido.OrdenarPorFecha);
            }
        }

        /// <summary>
        /// Ordena y formateo la forma en que los datos se muestran en el datagrid
        /// </summary>
        private void OrdenarDGV()
        {
            this.dgvPedidosTotales.Columns[1].Visible = false;
            this.dgvPedidosTotales.Columns[7].Visible = false;
            this.dgvPedidosTotales.Columns[0].Width = 150;
            this.dgvPedidosTotales.Columns[2].Width = 200;
        }

    }
}
