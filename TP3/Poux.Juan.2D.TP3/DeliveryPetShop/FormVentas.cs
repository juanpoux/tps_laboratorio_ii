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
        }

        public FormVentas(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            this.listBoxProductosEnStock.SelectedItem = -1;
            this.cboMedioDePago.Items.Add("Efectivo");
            this.cboMedioDePago.Items.Add("Tarjeta");

            this.cboMedioDePago.SelectedIndex = 0;//Pruebas
            this.numericCantidad.Value = 1;//Pruebas

            this.alimentosPedido = new List<Alimento>();
            this.alimentosEnStock = new List<Alimento>();

            //Leer archivo json
            try
            {
                string ubicacionYNombreArchivo = AppDomain.CurrentDomain.BaseDirectory + @"\ListaAlimentos.json";
                this.alimentosEnStock = JsonSerializer.Deserialize<List<Alimento>>(File.ReadAllText(ubicacionYNombreArchivo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dgvAlimentosPedido.AutoGenerateColumns = false;

            this.Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alimento alimentoPerro = (Alimento)this.listBoxProductosEnStock.SelectedItem;
            int cantidad = (int)this.numericCantidad.Value;

            alimentoPerro.Cantidad = cantidad;

            bool bandera = false;
            foreach (Alimento item in this.alimentosPedido)
            {
                if (item == alimentoPerro)
                {
                    bandera = true;
                    item.Cantidad += alimentoPerro.Cantidad;
                    item.PrecioEf += alimentoPerro.PrecioEf;
                    item.PrecioTarj += alimentoPerro.PrecioTarj;
                    break;
                }
            }
            if (!bandera)
            {
                Alimento alimento = new Alimento(alimentoPerro.Descripcion, alimentoPerro.Kilos, alimentoPerro.PrecioEf, alimentoPerro.PrecioTarj);
                alimento.Cantidad = alimentoPerro.Cantidad;
                this.alimentosPedido.Add(alimento);
            }
            this.CargarListaAlimentosPedidos();
        }

        private void ActualizarTotales()
        {
            if (this.alimentosPedido.Count > -1)
            {
                this.acumuladorTarjeta = 0;
                this.acumuladorEfectivo = 0;
                foreach (Alimento item in this.alimentosPedido)
                {
                    this.acumuladorTarjeta += item.PrecioTarj;
                    this.acumuladorEfectivo += item.PrecioEf;
                }
                this.lblTotalTarjeta.Text = this.acumuladorTarjeta.ToString("C");
                this.lblTotalEfectivo.Text = this.acumuladorEfectivo.ToString("C");
            }
        }

        private void CargarListaAlimentosPedidos()
        {
            this.dgvAlimentosPedido.AutoGenerateColumns = true;
            this.dgvAlimentosPedido.DataSource = null;
            this.dgvAlimentosPedido.DataSource = this.alimentosPedido;
            this.dgvAlimentosPedido.Columns[0].Width = 310;
            this.dgvAlimentosPedido.Columns[1].Width = 60;
            this.dgvAlimentosPedido.Columns[3].HeaderText = "Efectivo $";
            this.dgvAlimentosPedido.Columns[4].HeaderText = "Tarjeta $";
            //this.dataGridView1.Columns[2].Visible = false;
            this.ActualizarTotales();
        }

        private void Cargar()
        {
            this.listBoxProductosEnStock.DataSource = null;
            this.listBoxProductosEnStock.DataSource = this.alimentosEnStock;
            this.dgvAlimentosStock.AutoGenerateColumns = true;
            this.dgvAlimentosStock.DataSource = null;
            this.dgvAlimentosStock.DataSource = this.alimentosEnStock;
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
            //hacer validacion si elige pago con tarjeta o efectivo para asignar el precio
            //agregué atributo pagoenefectivo en PEIDO
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

            MessageBox.Show("Pedido cargado!", "Pedido cargado");
            this.DialogResult = DialogResult.OK;
        }

        private void listBoxProductosEnStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxProductosEnStock.DataSource is not null)
            {
                this.lblPrecio.Text = ((Alimento)this.listBoxProductosEnStock.SelectedItem).PrecioEf.ToString("C");
                this.lblPrecioTarj.Text = ((Alimento)this.listBoxProductosEnStock.SelectedItem).PrecioTarj.ToString("C");
            }
        }

        private void txtBuscarPorNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBuscarPorNombre.Text))
            {
                this.listBoxProductosEnStock.DataSource = null;
                List<Alimento> listita = new List<Alimento>();
                foreach (Alimento item in this.alimentosEnStock)
                {
                    if (item.Descripcion.ToLower().StartsWith(this.txtBuscarPorNombre.Text.ToLower()))
                    {
                        listita.Add(item);

                    }
                }
                this.listBoxProductosEnStock.DataSource = listita;
            }
            else
            {
                this.Cargar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
