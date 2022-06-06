using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : IProducto
    {
        //Atributos
        private string descripcion;
        private double kilos;
        private int cantidad;
        private double precio;
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

        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
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

        public Alimento()
        {

        }

        public Alimento(string descripcion, double kilos, double precioEf, double precioTarj)
        {
            this.descripcion = descripcion;
            this.kilos = kilos;
            this.precio = precioEf;
            this.precioTarj = precioTarj;
        }

        /// <summary>
        /// Formatea los datos de un alimento para mostrar
        /// </summary>
        /// <param name="tipoPago"></param>
        /// <returns>Datos del alimento formateados en tipo string</returns>
        public string MostrarAlimentoPorTipoPago(ETipoPago tipoPago)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.cantidad} - {this.descripcion} - {this.kilos}kg ");
            if (tipoPago == ETipoPago.Efectivo)
            {
                sb.Append($"- {this.precio:C}");
            }
            else if (tipoPago == ETipoPago.Tarjeta)
            {
                sb.Append($"- {this.precioTarj:C}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Compara si dos alimentos tienen los mismos datos
        /// </summary>
        /// <param name="a">alimento 1</param>
        /// <param name="b">alimento 2</param>
        /// <returns>retorna true si son iguales, false de caso contrario</returns>
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

        /// <summary>
        /// Compara si dos alimentos tienen distintos datos
        /// </summary>
        /// <param name="a">alimento 1</param>
        /// <param name="b">alimento 2</param>
        /// <returns>retorna true si son distintos, false de caso contrario</returns>
        public static bool operator !=(Alimento a, Alimento b)
        {
            return !(a == b);
        }

        /// <summary>
        /// /// <summary>
        /// Compara si dos alimentos son del mismo tipo y si son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar con un cliente</param>
        /// <returns>retorna true si son iguales, false de caso contrario</returns>
        public override bool Equals(object obj)
        {
            Alimento alimento = obj as Alimento;
            return alimento is not null && this == alimento;
        }

        /// <summary>
        /// Formatea los datos de un alimento para mostrar
        /// </summary>
        /// <returns>Datos del alimento formateados en tipo string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.descripcion} - {this.kilos}kg - {this.precio:C} - {this.precioTarj:C}");
            return sb.ToString();
        }
    }
}
