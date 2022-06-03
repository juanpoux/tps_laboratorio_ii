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
        double acumuladorEfectivo = 0;
        double acumuladorTarjeta = 0;

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
            this.lblDia.Text = DateTime.Now.ToShortDateString();
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

            this.listBoxProductosEnStock.DataSource = this.alimentosEnStock;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.numericCantidad.Value == 0)
            {
                MessageBox.Show("Debe seleccionar una cantidad");
            }
            else if (this.cboMedioDePago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un medio de pago");
            }
            else if (this.listBoxProductosEnStock.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
            else
            {
                int index = this.listBoxProductosEnStock.SelectedIndex;
                Alimento alimentoPerro = this.alimentosEnStock[index];
                int cantidad = (int)this.numericCantidad.Value;

                this.acumuladorEfectivo += (alimentoPerro.PrecioEf * cantidad);
                this.acumuladorTarjeta += (alimentoPerro.PrecioTarj * cantidad);
                this.lblTotalTarjeta.Text = this.acumuladorTarjeta.ToString("C");
                this.lblTotalEfectivo.Text = this.acumuladorEfectivo.ToString("C");
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
                this.Cargar();
            }
        }

        private void Cargar()
        {
            this.listBoxProductosPedidos.Items.Clear();
            foreach (Alimento item in this.alimentosPedido)
            {
                this.listBoxProductosPedidos.Items.Add(item.MostrarAlimentoConUnidades());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int index = this.listBoxProductosPedidos.SelectedIndex;
            //if (index > -1)
            //{
            //    this.listBoxProductosPedidos.Items.RemoveAt(index);
            //    this.alimentosPedido.RemoveAt(index);
            //}

            foreach (Alimento item in this.alimentosPedido)
            {
                if (this.listBoxProductosPedidos.SelectedItem.ToString().Contains(item.Descripcion))
                {
                    this.alimentosPedido.Remove(item);
                    break;
                }
            }
            this.Cargar();
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

            MessageBox.Show("Pedido cargado!", "Pedido cargado");
            this.DialogResult = DialogResult.OK;
        }

        private void listBoxProductosEnStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBoxProductosEnStock.SelectedIndex;
            if (index > -1)
            {
                //this.lblPrecio.Text = this.alimentosEnStock[index].PrecioEf.ToString("C");
                //this.lblPrecioTarj.Text = alimentosEnStock[index].PrecioTarj.ToString("C");
            }
            this.lblPrecio.Text = ((Alimento)this.listBoxProductosEnStock.SelectedItem).PrecioEf.ToString("C");
            this.lblPrecioTarj.Text = ((Alimento)this.listBoxProductosEnStock.SelectedItem).PrecioTarj.ToString("C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
