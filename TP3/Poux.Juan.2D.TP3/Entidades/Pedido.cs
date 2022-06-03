using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        //Atributos
        private Cliente cliente;
        private List<Alimento> alimentosPedidos;
        private bool pago;
        private DateTime diaDeEntrega;
        private double precioFinal;
        private bool efectivo;
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
        public bool Efectivo
        {
            get
            {
                return this.efectivo;
            }
            set
            {
                this.efectivo = value;
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
        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"{this.cliente.MostrarCliente()}");
            sb.AppendLine($"*Pedido para el dia {this.diaDeEntrega.ToShortDateString()}");

            foreach (Alimento item in this.alimentosPedidos)
            {
                sb.AppendLine("  -" + item.MostrarAlimentoPorTipoPago(tipoPago));
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
            sb.AppendLine();
            return sb.ToString();
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0;
            foreach (Alimento item in this.alimentosPedidos)
            {
                precioTotal += item.PrecioEf;
            }
            return precioTotal;
        }

        //Sobrecargas
        public static bool operator ==(Pedido pedido, Cliente cliente)
        {
            bool retorno = false;
            if (pedido is not null && cliente is not null && pedido.cliente == cliente)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pedido pedido, Cliente cliente)
        {
            return !(pedido == cliente);
        }

        //public static Pedido operator +(Pedido pedido, Alimento alimento)
        //{
        //    if (pedido is not null && alimento is not null && pedido != alimento
        //        && alimento.Stock > 0)
        //    {
        //        //pedido.alimentosPedidos.Add(alimento);
        //        alimento.Stock--;
        //    }
        //    return pedido;
        //}

        //public static Pedido operator -(Pedido pedido, Alimento alimento)
        //{
        //    if (pedido == alimento)
        //    {
        //        //pedido.alimentosPedidos.Remove(alimento);
        //    }
        //    return pedido;
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{cliente.Nombre} - {cliente.Direccion} - ");
            if (this.pago)
            {
                sb.Append("PAGO - ");
            }
            else
            {
                //sb.Append(" - NO PAGO - ");
            }
            sb.Append($"{this.diaDeEntrega.ToShortDateString()}");
            return sb.ToString();
        }
    }
}
