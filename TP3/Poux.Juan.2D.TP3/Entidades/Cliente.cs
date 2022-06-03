﻿using System;
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

        public Cliente(string telefono, string nombre, string direccion)
        {
            this.telefono = telefono;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*Cliente: {this.nombre}");
            sb.AppendLine($"*Telefono: {this.telefono}");
            sb.AppendLine($"*Direccion: {this.direccion}");
            return sb.ToString();
        }

        public string MostrarHistorial()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(this.MostrarCliente()); //Si hizo un pedido se duplica el MostrarCliente
            //foreach (Pedido item in this.alimentosPedidos)
            //{
            //    sb.AppendLine(item.MostrarPedido());
            //}

            return sb.ToString();
        }

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

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente is not null && this == cliente;
        }

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
