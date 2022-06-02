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
                //string ubicacionYNombreArchivo = AppDomain.CurrentDomain.BaseDirectory + @"\ListaClientes.json";
                string ubicacionYNombreArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaAlimentos.js";
                this.alimentosEnStock = JsonSerializer.Deserialize<List<Alimento>>(File.ReadAllText(ubicacionYNombreArchivo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //this.alimentosEnStock = new()
            //{
            //    new Alimento("Royal Canin Mini Adult", 7.5, 500, 550),
            //    new Alimento("Royal Canin Medium Adult", 15, 900, 990),
            //    new Alimento("Royal Canin Maxi Adult", 15, 900, 990),
            //    new Alimento("Balanced Adulto Razas Medianas", 20, 800, 890),
            //    new Alimento("Balanced Adulto Razas Grandes", 20, 800, 890),
            //    new Alimento("Pro Plan Adulto Razas Pequeñas", 7.5, 450, 490),
            //    new Alimento("Pro Plan Adulto Razas Medianas", 15, 950, 990),
            //    new Alimento("Pro Plan Active Mind Razas Pequeñas", 7.5, 550, 590),
            //    new Alimento("Pro Plan Active Mind Razas Medianas", 15, 950, 990)

            //};

            //try
            //{
            //    JsonSerializerOptions opciones = new JsonSerializerOptions();
            //    opciones.WriteIndented = true;
            //    string ubicacionYNombreArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaAlimentos.json";
            //    File.WriteAllText(ubicacionYNombreArchivo, JsonSerializer.Serialize(this.alimentosEnStock, opciones));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            Dictionary<string, Alimento> valoresCombo = new Dictionary<string, Alimento>();
            foreach (Alimento item in alimentosEnStock)
            {
                valoresCombo.Add(item.Descripcion + item.Kilos, item);
            }
            this.cboProducto.DisplayMember = "Key";
            this.cboProducto.ValueMember = "Value";
            this.cboProducto.DataSource = valoresCombo.ToArray();

            foreach (Alimento item in alimentosEnStock)
            {
                //this.listBoxProductosEnStock.Items.Add(item.MostrarAlimento());
                this.listBoxProductosEnStock.Items.Add(item.MostrarAlimento());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alimento alimentoPerro = this.DevolverAlimentoSeleccionado();
            if (alimentoPerro is not null)
            {
                this.lblPrecio.Text = alimentoPerro.PrecioEf.ToString("C");
                this.lblPrecioTarj.Text = alimentoPerro.PrecioTarj.ToString("C");
            }
        }

        private Alimento DevolverAlimentoSeleccionado()
        {
            Alimento alimentoPerro = null;
            if (this.cboProducto.SelectedItem != null)
            {
                alimentoPerro = ((KeyValuePair<string, Alimento>)this.cboProducto.SelectedItem).Value;
            }
            return alimentoPerro;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //if (this.cboProducto.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe seleccionar un producto");
            //}
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
                //Alimento alimentoPerro = this.DevolverAlimentoSeleccionado();

                //precioFinal = precio * cantidad;
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

                //this.btnLimpiar_Click(sender, e);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cboProducto.Text = "(Seleccione producto)";
            //this.cboMedioDePago.Text = "(Seleccione medio de pago)";
            this.numericCantidad.Value = 0;
            this.lblPrecio.Text = (0).ToString("C");
            this.lblPrecioTarj.Text = (0).ToString("C");
            this.cboProducto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = this.listBoxProductosPedidos.SelectedIndex;
            if (index > -1)
            {
                this.listBoxProductosPedidos.Items.RemoveAt(index);
                this.alimentosPedido.RemoveAt(index);
            }
        }

        private void btnEnviarPedido_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Alimento item in this.alimentosPedido)
            {
                sb.AppendLine($"{item.Descripcion}");
            }
            pedido = new Pedido(this.cliente, true, DateTime.Now);
            pedido.alimentosPedidos = this.alimentosPedido;
            //hacer validacion si elige pago con tarjeta o efectivo para asignar el precio
            //agregué atributo pagoenefectivo en PEIDO
            if (this.cboMedioDePago.Text == "Efectivo")
            {
                pedido.tipoPago = ETipoPago.Efectivo;
                pedido.precioFinal = this.acumuladorEfectivo;
            }
            else
            {
                pedido.tipoPago = ETipoPago.Tarjeta;
                pedido.precioFinal = this.acumuladorTarjeta;
            }

            if (cbPagoElPedido.Checked)
            {
                pedido.pago = true;
            }
            else
            {
                pedido.pago = false;
            }
            pedido.diaDeEntrega = this.dateTimePicker1.Value;

            MessageBox.Show("Pedido cargado!", "Pedido cargado");
            this.DialogResult = DialogResult.OK;
        }

        private void listBoxProductosEnStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBoxProductosEnStock.SelectedIndex;
            if (index > -1)
            {
                this.lblPrecio.Text = this.alimentosEnStock[index].PrecioEf.ToString("C");
                this.lblPrecioTarj.Text = alimentosEnStock[index].PrecioTarj.ToString("C");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
