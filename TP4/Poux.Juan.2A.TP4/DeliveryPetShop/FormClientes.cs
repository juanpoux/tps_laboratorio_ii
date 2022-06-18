using DeliveryPetShop;
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

        /// <summary>
        /// Carga el datagrid con los clientes hardcodeados y crea el directorio en el escritorio para guardar la lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.Cargar();
            //this.EscribirClientes();
        }

        /// <summary>
        /// Abre el formulario de ventas para cargarle un pedido al cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                FormVentas formVentas = new FormVentas((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                formVentas.ShowDialog();
                switch (formVentas.DialogResult)
                {
                    case DialogResult.OK:
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

        /// <summary>
        /// abre el formulario de modificaciones para poder modificar los datos del cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                FormModificarCliente formModificarCliente = new FormModificarCliente((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                formModificarCliente.ShowDialog();
                if (formModificarCliente.DialogResult == DialogResult.OK)
                {
                    ClienteDao.Modificar(formModificarCliente.clienteAux);
                    //this.EscribirClientes();
                }
                this.Cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Crea una lista auxiliar con la lista de clientes para mostrarlos en datagrid
        /// </summary>
        private void Cargar()
        {
            List<Cliente> listaAuxiliar = new List<Cliente>();
            foreach (Cliente item in this.listaClientes)
            {
                if (item.Activo)
                {
                    listaAuxiliar.Add(item);
                }
            }
            this.dgvClientes.DataSource = null;
            this.dgvClientes.DataSource = listaAuxiliar;
            if (listaAuxiliar.Count > 0)
            {
                this.dgvClientes.ClearSelection();
            }
            this.OrdenarDGV();
        }

        /// <summary>
        /// Ordena los datos que se muestran en el datagrid
        /// </summary>
        private void OrdenarDGV()
        {
            this.dgvClientes.Columns[0].Visible = false;
            this.dgvClientes.Columns[4].Visible = false;
        }

        /// <summary>
        /// Abre un formulario para crear un cliente nuevo y agregarlo a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
            if (formNuevoCliente.DialogResult == DialogResult.OK)
            {
                this.listaClientes.Add(formNuevoCliente.cliente);
                ClienteDao.Guardar(formNuevoCliente.cliente);
                this.Cargar();
                //this.EscribirClientes();
            }
        }

        /// <summary>
        /// De no existir crea un archivo JSON con los datos de los clientes cargados en la lista
        /// </summary>
        //private void EscribirClientes()
        //{
        //    try
        //    {
        //        SerializacionConJson<List<Cliente>> serializacionConJson = new SerializacionConJson<List<Cliente>>();
        //        serializacionConJson.Escribir(this.listaClientes, "ListaClientes");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al intentar escribir lista de clientes\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        /// <summary>
        /// Muestra los pedidos realizados por el cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Crea una nueva lista para mostrar con los datos que coinciden con la busqueda en el txtBox y la muestra en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarPorDireccion_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorDireccion.Text is not null && this.txtBuscarPorDireccion.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listaAuxiliar = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Direccion.ToLower().StartsWith(this.txtBuscarPorDireccion.Text.ToLower())
                        && item.Activo)
                    {
                        listaAuxiliar.Add(item);
                    }
                }
                this.dgvClientes.DataSource = listaAuxiliar;
                this.OrdenarDGV();
            }
            else
            {
                this.Cargar();
            }
        }

        /// <summary>
        /// Crea una nueva lista para mostrar con los datos que coinciden con la busqueda en el txtBox y la muestra en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarPorTelefono_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorTelefono.Text is not null && this.txtBuscarPorTelefono.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listaAuxiliar = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Telefono.ToLower().StartsWith(this.txtBuscarPorTelefono.Text.ToLower())
                        && item.Activo)
                    {
                        listaAuxiliar.Add(item);
                    }
                }
                this.dgvClientes.DataSource = listaAuxiliar;
                this.OrdenarDGV();
            }
            else
            {
                this.Cargar();
            }
        }

        /// <summary>
        /// Crea una nueva lista para mostrar con los datos que coinciden con la busqueda en el txtBox y la muestra en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorNombre.Text is not null && this.txtBuscarPorNombre.Text != string.Empty)
            {
                this.dgvClientes.DataSource = null;
                List<Cliente> listaAuxiliar = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Nombre.ToLower().StartsWith(this.txtBuscarPorNombre.Text.ToLower())
                        && item.Activo)
                    {
                        listaAuxiliar.Add(item);

                    }
                }
                this.dgvClientes.DataSource = listaAuxiliar;
                this.OrdenarDGV();
            }
            else
            {
                this.Cargar();
            }
        }

        /// <summary>
        /// Cierra el formulario y cambia el DialogResulto a Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Cambia el estado "Activo" del cliente a false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Seguro desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.cliente = ((Cliente)this.dgvClientes.CurrentRow.DataBoundItem);
                    cliente.Activo = false;
                    ClienteDao.Modificar(cliente);
                    //this.EscribirClientes();
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
