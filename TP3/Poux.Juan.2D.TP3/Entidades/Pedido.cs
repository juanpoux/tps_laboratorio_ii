using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoPago
    {
        Efectivo,
        Tarjeta,
    }
    public class Pedido
    {
        //Atributos
        private Cliente cliente;
        private List<Alimento> alimentosPedidos;
        private bool pago;
        private DateTime diaDeEntrega;
        private double precioFinal;
        private ETipoPago tipoPago;
        private string observaciones;

        //Constructores
        private Pedido()
        {
            this.alimentosPedidos = new List<Alimento>();
        }

        public Pedido(Cliente cliente, bool pago, DateTime diaDeEntrega) : this()
        {
            this.pago = pago;
            this.diaDeEntrega = diaDeEntrega;
            this.cliente = cliente;
            this.precioFinal = 0;
        }

        //Propiedades
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }

        [JsonIgnore]
        public string NombreCliente
        {
            get
            {
                return this.Cliente.Nombre;
            }
        }

        [JsonIgnore]
        public string DireccionCliente
        {
            get
            {
                return this.Cliente.Direccion;
            }
        }

        public List<Alimento> AlimentosPedidos
        {
            get
            {
                return this.alimentosPedidos;
            }
            set
            {
                this.alimentosPedidos = value;
            }
        }
        public DateTime DiaDeEntrega
        {
            get
            {
                return this.diaDeEntrega;
            }
            set
            {
                this.diaDeEntrega = value;
            }
        }
        public double PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
            set
            {
                this.precioFinal = value;
            }
        }

        public bool Pago
        {
            get
            {
                return this.pago;
            }
            set
            {
                this.pago = value;
            }
        }

        public ETipoPago TipoPago
        {
            get
            {
                return this.tipoPago;
            }
            set
            {
                this.tipoPago = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return this.observaciones;
            }
            set
            {
                this.observaciones = value;
            }
        }


        //Metodos

        /// <summary>
        /// Formatea los datos de un pedido para mostrar
        /// </summary>
        /// <returns>Datos del pedido formateados en tipo string</returns>
        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*Pedido para el dia {this.diaDeEntrega.ToShortDateString()}");

            foreach (Alimento item in this.alimentosPedidos)
            {
                sb.AppendLine("  -" + item.MostrarAlimentoPorTipoPago(this.tipoPago));
            }
            sb.AppendLine($"*Precio final: ${this.precioFinal}");
            if (this.pago)
            {
                sb.Append("****** Pedido pago ");
                if (this.tipoPago == ETipoPago.Efectivo)
                {
                    sb.AppendLine("en efectivo ******");
                }
                else
                {
                    sb.AppendLine("con tarjeta ******");
                }
            }
            else
            {
                sb.AppendLine("****** Pedido SIN pagar *******");
            }
            if (!string.IsNullOrEmpty(this.observaciones))
            {
                sb.AppendLine($"*Obersvaciones: {this.observaciones}");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        //Sobrecargas

        /// <summary>
        /// Evalua si el cliente dentro del pedido es el mismo que recibe por parametro
        /// </summary>
        /// <param name="pedido">Pedido donde se busca al cliente</param>
        /// <param name="cliente">Cliente a comparar con el del pedido</param>
        /// <returns>Retorna true si el cliente es el mismo del pedido, false de lo contrario</returns>
        public static bool operator ==(Pedido pedido, Cliente cliente)
        {
            bool retorno = false;
            if (pedido is not null && cliente is not null && pedido.cliente == cliente)
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// Evalua si el cliente dentro del pedido es distinto del que recibe por parametro
        /// </summary>
        /// <param name="pedido">Pedido donde se busca al cliente</param>
        /// <param name="cliente">Cliente a comparar con el del pedido</param>
        /// <returns>Retorna true si son distintos, false de caso contrario</returns>
        public static bool operator !=(Pedido pedido, Cliente cliente)
        {
            return !(pedido == cliente);
        }

        /// <summary>
        /// Llama al metodo MostrarPedido()
        /// </summary>
        /// <returns>Datos del pedido formateados en tipo string</returns>
        public override string ToString()
        {
            return this.MostrarPedido();
        }
    }
}
