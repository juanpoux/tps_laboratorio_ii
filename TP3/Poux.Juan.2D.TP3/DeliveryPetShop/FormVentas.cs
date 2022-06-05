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

        private void FormInicio_Load(object sender, EventArgs e)
        {
            this.cboMedioDePago.Items.Add("Efectivo");
            this.cboMedioDePago.Items.Add("Tarjeta");

            this.cboMedioDePago.SelectedIndex = 0;
            this.numericCantidad.Value = 1;

            try
            {
                SerializacionConXml<List<Alimento>> serializacionConXml = new SerializacionConXml<List<Alimento>>();
                this.alimentosEnStock = serializacionConXml.Leer("ListaAlimentos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error serializando alimentos\n" + ex.Message);
            }
            this.Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alimento alimentoPerro = (Alimento)this.dgvAlimentosStock.CurrentRow.DataBoundItem;
            int cantidad = (int)this.numericCantidad.Value;

            alimentoPerro.Cantidad = cantidad;

            bool bandera = false;
            foreach (Alimento item in this.alimentosPedido)
            {
                if (item == alimentoPerro)
                {
                    bandera = true;
                    item.Cantidad += alimentoPerro.Cantidad;
                    item.Precio += alimentoPerro.Precio;
                    item.PrecioTarj += alimentoPerro.PrecioTarj;
                    break;
                }
            }
            if (!bandera)
            {
                Alimento alimento = new Alimento(alimentoPerro.Descripcion, alimentoPerro.Kilos, alimentoPerro.Precio, alimentoPerro.PrecioTarj);
                alimento.Cantidad = alimentoPerro.Cantidad;
                this.alimentosPedido.Add(alimento);
            }
            this.CargarListaAlimentosPedidos();
        }

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

        private void CargarListaAlimentosPedidos()
        {
            this.dgvAlimentosPedido.DataSource = null;
            this.dgvAlimentosPedido.DataSource = this.alimentosPedido;
            this.dgvAlimentosPedido.Columns[0].Width = 310;
            this.dgvAlimentosPedido.Columns[1].Width = 60;
            this.dgvAlimentosPedido.Columns[3].HeaderText = "Efectivo $";
            this.dgvAlimentosPedido.Columns[4].HeaderText = "Tarjeta $";
            this.ActualizarTotales();
        }

        private void Cargar()
        {
            this.dgvAlimentosPedido.AutoGenerateColumns = true;
            this.dgvAlimentosStock.DataSource = null;
            this.dgvAlimentosStock.DataSource = this.alimentosEnStock;
            this.OrdenarDGV();
        }

        private void OrdenarDGV()
        {
            this.dgvAlimentosStock.Columns[0].Width = 300;
            this.dgvAlimentosStock.Columns[1].Width = 55;
            this.dgvAlimentosStock.Columns[2].Visible = false;
            this.dgvAlimentosStock.Columns[3].HeaderText = "Efectivo $";
            this.dgvAlimentosStock.Columns[4].HeaderText = "Tarjeta $";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.alimentosPedido.Remove((Alimento)this.dgvAlimentosPedido.CurrentRow.DataBoundItem);
            this.CargarListaAlimentosPedidos();
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Alimento item in this.alimentosPedido)
            {
                sb.AppendLine($"{item.Descripcion}");
            }
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

            //MessageBox.Show("Pedido cargado!", "Pedido cargado");
            this.DialogResult = DialogResult.OK;
        }

        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBuscarPorNombre.Text))
            {
                this.dgvAlimentosStock.DataSource = null;
                List<Alimento> listita = new List<Alimento>();
                foreach (Alimento item in this.alimentosEnStock)
                {
                    if (item.Descripcion.ToLower().StartsWith(this.txtBuscarPorNombre.Text.ToLower()))
                    {
                        listita.Add(item);

                    }
                }
                this.dgvAlimentosStock.DataSource = listita;
                this.OrdenarDGV();
            }
            else
            {
                this.Cargar();
            }
        }


    }
}
