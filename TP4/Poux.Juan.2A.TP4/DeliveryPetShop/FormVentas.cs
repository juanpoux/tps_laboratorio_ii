using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PruebaTp3Form
{
    public partial class FormVentas : Form
    {
        List<Alimento> alimentosEnStock;
        List<Alimento> alimentosPedido;
        public Pedido pedido;
        Cliente cliente;
        double acumuladorEfectivo;
        double acumuladorTarjeta;

        public FormVentas()
        {
            InitializeComponent();
            this.alimentosPedido = new List<Alimento>();
            this.alimentosEnStock = new List<Alimento>();
        }

        public FormVentas(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }

        /// <summary>
        /// Se carga la lista de productos y se setean componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInicio_Load(object sender, EventArgs e)
        {
            this.cboMedioDePago.Items.Add("Efectivo");
            this.cboMedioDePago.Items.Add("Tarjeta");

            this.cboMedioDePago.SelectedIndex = 0;
            this.numericCantidad.Value = 1;

            this.LeerProductos();
            this.Cargar();
        }

        private void LeerProductos()
        {
            try
            {
                SerializacionConXml<List<Alimento>> serializacionConXml = new SerializacionConXml<List<Alimento>>();
                this.alimentosEnStock = serializacionConXml.LeerDesdeSolucion("ListaAlimentos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error serializando alimentos\n" + ex.Message);
            }
        }

        /// <summary>
        /// Cierra el formulario y cambia el dialog result a cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Si no existe el producto crea y carga un nuevo producto a la lista de pedidos, si ya existe suma la cantidad asignada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alimento alimentoPerro = (Alimento)this.dgvAlimentosStock.CurrentRow.DataBoundItem;
            int cantidad = (int)this.numericCantidad.Value;
            if (cantidad > 0)
            {
                alimentoPerro.Cantidad = cantidad;

                bool bandera = false;
                foreach (Alimento item in this.alimentosPedido)
                {
                    if (item == alimentoPerro)
                    {
                        bandera = true;
                        item.Cantidad += alimentoPerro.Cantidad;
                        item.Precio += (alimentoPerro.Precio * alimentoPerro.Cantidad);
                        item.PrecioTarj += (alimentoPerro.PrecioTarj * alimentoPerro.Cantidad);
                        break;
                    }
                }
                if (!bandera)
                {
                    Alimento alimento = new Alimento(alimentoPerro.Descripcion, alimentoPerro.Kilos, alimentoPerro.Precio * alimentoPerro.Cantidad, alimentoPerro.PrecioTarj * alimentoPerro.Cantidad);
                    alimento.Cantidad = alimentoPerro.Cantidad;
                    this.alimentosPedido.Add(alimento);
                }
                this.CargarListaAlimentosPedidos();
            }
            else
            {
                MessageBox.Show("Debe poner al menos 1 en cantidad");
            }
        }

        /// <summary>
        /// Actualiza los labels que muestran la suma de los totales de efectivo y tarjeta
        /// </summary>
        private void ActualizarTotales()
        {
            this.lblTotalTarjeta.Text = 0.ToString("C");
            this.lblTotalEfectivo.Text = 0.ToString("C");
            if (this.alimentosPedido.Count > -1)
            {
                this.acumuladorTarjeta = 0;
                this.acumuladorEfectivo = 0;
                foreach (Alimento item in this.alimentosPedido)
                {
                    this.acumuladorTarjeta += item.PrecioTarj;
                    this.acumuladorEfectivo += item.Precio;
                }
                this.lblTotalTarjeta.Text = this.acumuladorTarjeta.ToString("C");
                this.lblTotalEfectivo.Text = this.acumuladorEfectivo.ToString("C");
            }
        }

        /// <summary>
        /// Carga el datagrid con la lista de productos pedidos
        /// </summary>
        private void CargarListaAlimentosPedidos()
        {
            this.dgvAlimentosPedido.DataSource = null;
            this.dgvAlimentosPedido.DataSource = this.alimentosPedido;
            this.OrdenarDGVPedidos();
            this.ActualizarTotales();
        }

        /// <summary>
        /// Formatea el datagrid con la lista de productos pedidos
        /// </summary>
        private void OrdenarDGVPedidos()
        {
            this.dgvAlimentosPedido.Columns[0].Width = 310;
            this.dgvAlimentosPedido.Columns[1].Width = 60;
            this.dgvAlimentosPedido.Columns[3].HeaderText = "Efectivo $";
            this.dgvAlimentosPedido.Columns[4].HeaderText = "Tarjeta $";
        }

        /// <summary>
        /// Carga el datagrid con la lista de productos a la venta 
        /// </summary>
        private void Cargar()
        {
            this.dgvAlimentosPedido.AutoGenerateColumns = true;
            this.dgvAlimentosStock.DataSource = null;
            this.dgvAlimentosStock.DataSource = this.alimentosEnStock;
            this.OrdenarDGVStock();
        }

        /// <summary>
        /// Formatea el datagrid con la lista de productos a la venta 
        /// </summary>
        private void OrdenarDGVStock()
        {
            this.dgvAlimentosStock.Columns[0].Width = 310;
            this.dgvAlimentosStock.Columns[1].Width = 55;
            this.dgvAlimentosStock.Columns[2].Visible = false;
            this.dgvAlimentosStock.Columns[3].HeaderText = "Efectivo $";
            this.dgvAlimentosStock.Columns[4].HeaderText = "Tarjeta $";
        }

        /// <summary>
        /// Elimina de la lista y del datagrid el producto seleccionado en la lista de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (this.dgvAlimentosPedido.SelectedRows.Count > 0)
            {
                this.alimentosPedido.Remove((Alimento)this.dgvAlimentosPedido.CurrentRow.DataBoundItem);
                this.CargarListaAlimentosPedidos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Crea un pedido nuevo, lo carga con los datos obtenidos en los componentes del formulario y cambia el DialogResult a OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {
            pedido = new Pedido(this.cliente, true, DateTime.Now);
            pedido.AlimentosPedidos = this.alimentosPedido;

            if (this.cboMedioDePago.Text == "Efectivo")
            {
                pedido.TipoPago = ETipoPago.Efectivo;
                pedido.PrecioFinal = this.acumuladorEfectivo;
            }
            else
            {
                pedido.TipoPago = ETipoPago.Tarjeta;
                pedido.PrecioFinal = this.acumuladorTarjeta;
            }

            if (cbPagoElPedido.Checked)
            {
                pedido.Pago = true;
            }
            else
            {
                pedido.Pago = false;
            }

            pedido.DiaDeEntrega = this.dateTimePicker1.Value;
            pedido.Observaciones = this.rtbObervaciones.Text;
            if (this.alimentosPedido.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un producto al pedido");
            }
        }

        /// <summary>
        /// Crea una nueva lista para mostrar con los datos que coinciden con la busqueda en el txtBox y la muestra en el datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBuscarPorNombre.Text))
            {
                this.dgvAlimentosStock.DataSource = null;
                List<Alimento> listaAuxiliar = new List<Alimento>();
                foreach (Alimento item in this.alimentosEnStock)
                {
                    if (item.Descripcion.ToLower().StartsWith(this.txtBuscarPorNombre.Text.ToLower()))
                    {
                        listaAuxiliar.Add(item);
                    }
                }
                this.dgvAlimentosStock.DataSource = listaAuxiliar;
                this.OrdenarDGVStock();
            }
            else
            {
                this.Cargar();
            }
        }
    }
}
