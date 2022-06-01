using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        public enum ETipoPago
        {
            Efectivo,
            Tarjeta,
        }
    public class Alimento
    {
        //Atributos
        private string descripcion;
        private double kilos;
        private int cantidad;
        private double precioEf;
        private double precioTarj;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public double Kilos
        {
            get
            {
                return this.kilos;
            }
            set
            {
                this.kilos = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public double PrecioEf
        {
            get
            {
                return this.precioEf;
            }
            set
            {
                this.precioEf = value;
            }
        }

        public double PrecioTarj
        {
            get
            {
                return this.precioTarj;
            }
            set
            {
                this.precioTarj = value;
            }
        }

        public Alimento(string descripcion, double kilos, double precioEf, double precioTarj)
        {
            this.descripcion = descripcion;
            this.kilos = kilos;
            this.precioEf = precioEf;
            this.precioTarj = precioTarj;
        }

        public Alimento(string descripcion, double kilos, double precioEf, double precioTarj, int cantidad)
        {
            this.descripcion = descripcion;
            this.kilos = kilos;
            this.precioEf = precioEf;
            this.precioTarj = precioTarj;
            this.cantidad = cantidad;
        }

        public string MostrarAlimentoConUnidades()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.cantidad} - {this.descripcion} - {this.kilos}kg - {this.precioEf:C} - {this.precioTarj:C}");
            return sb.ToString();
        }

        public string MostrarAlimentoPorTipoPago(ETipoPago tipoPago)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append($"{this.cantidad} - {this.descripcion} - {this.kilos}kg "); /*- {this.precioEf:C} - {this.precioTarj:C}*/
            if(tipoPago == ETipoPago.Efectivo)
            {
                sb.Append($"- {this.precioEf:C}");
            }
            else if(tipoPago == ETipoPago.Tarjeta)
            {
                sb.Append($"- {this.precioTarj:C}");
            }
            return sb.ToString();
        }

        public static bool operator ==(Alimento a, Alimento b)
        {
            bool retorno = false;
            if (a is not null && b is not null &&
                a.descripcion == b.descripcion && a.kilos == b.kilos)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Alimento a, Alimento b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Alimento alimento = obj as Alimento;
            return alimento is not null && this == alimento;
        }

        //public override string ToString()
        //{
        //    //StringBuilder sb = new StringBuilder();
        //    //sb.Append($"{this.descripcion} - {this.kilos}kg - {this.precioEf:C} - {this.precioTarj:C}");
        //    return MostrarAlimentoSinUnidades();
        //}
    }
}
