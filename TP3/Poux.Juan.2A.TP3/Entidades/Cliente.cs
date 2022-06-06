using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string telefono;
        private string direccion;
        private bool activo;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }
        }

        public Cliente(string telefono, string nombre, string direccion)
        {
            this.telefono = telefono;
            this.nombre = nombre;
            this.direccion = direccion;
            this.activo = true;
        }

        /// <summary>
        /// Formatea los datos de un cliente para mostrar
        /// </summary>
        /// <returns>Datos del cliente formateados en tipo string</returns>
        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*Cliente: {this.nombre}");
            sb.AppendLine($"*Telefono: {this.telefono}");
            sb.AppendLine($"*Direccion: {this.direccion}");
            return sb.ToString();
        }

        /// <summary>
        /// Compara si dos clientes tienen los mismos datos
        /// </summary>
        /// <param name="a">cliente 1</param>
        /// <param name="b">cliente 2</param>
        /// <returns>retorna true si son iguales, false de caso contrario</returns>
        public static bool operator ==(Cliente a, Cliente b)
        {
            bool retorno = false;
            if (a is not null && b is not null && a.nombre == b.nombre
                && a.direccion == b.direccion)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara si dos clientes tienen distintos datos
        /// </summary>
        /// <param name="a">cliente 1</param>
        /// <param name="b">cliente 2</param>
        /// <returns>retorna true si son distintos, false de caso contrario</returns>
        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Compara si dos clientes son del mismo tipo y si son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar con un cliente</param>
        /// <returns>retorna true si son iguales, false de caso contrario</returns>
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente is not null && this == cliente;
        }

        /// <summary>
        /// Formatea los datos de un cliente para mostrar
        /// </summary>
        /// <returns>Datos del cliente formateados en tipo string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre} - ");
            sb.Append($"Telefono: {this.telefono} - ");
            sb.AppendLine($"Direccion: {this.direccion}");
            return sb.ToString();
        }
    }
}
