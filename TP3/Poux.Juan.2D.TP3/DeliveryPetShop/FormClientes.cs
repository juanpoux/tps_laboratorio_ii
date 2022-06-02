﻿using DeliveryPetShop;
using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


namespace PruebaTp3Form
{
    public partial class FormClientes : Form
    {
        public List<Cliente> listaClientes;
        public List<Pedido> listaPedidos;
        public Pedido pedido;
        public Cliente cliente;
        string path;

        public FormClientes()
        {
            InitializeComponent();
        }

        public FormClientes(List<Cliente> listaClientes, List<Pedido> listaPedidos) : this()
        {
            this.listaClientes = listaClientes;
            this.listaPedidos = listaPedidos;
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                //FormVentas formVentas = new FormVentas(this.listaClientes[index]);
                FormVentas formVentas = new FormVentas((Cliente)this.listBox1.SelectedItem);
                formVentas.ShowDialog();
                switch (formVentas.DialogResult)
                {
                    case DialogResult.OK:
                        //aca recupero el pedido de ventas
                        this.DialogResult = DialogResult.OK;
                        this.pedido = formVentas.pedido;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void EscribirClientes()
        {
            try
            {
                JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string ubicacionYNombreArchivo = Directory.GetCurrentDirectory() + @"\ListaClientes.json";
                File.WriteAllText(ubicacionYNombreArchivo, JsonSerializer.Serialize(this.listaClientes, opciones));
                //File.WriteAllText("/Archivos/ListaClientes.json", JsonSerializer.Serialize(clientes, opciones));
                //puede ser asi tambien, sin el directorio GUARDA/ESCRIBE el archivo en la carpeta debug
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo ubicado en {Directory.GetCurrentDirectory()}", ex);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {









            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            //path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path += @"\Clientes-TP3\";

            //string archivo = string.Empty;
            //string informacionRecuperada = string.Empty;
            //List<Cliente> datosRecuperados = default;
            //try
            //{
            //    if (Directory.Exists(path))
            //    {
            //        // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
            //        string[] archivosEnElPath = Directory.GetFiles(path);
            //        foreach (string path in archivosEnElPath)
            //        {
            //            if (path.Contains("SerializandoJson_Clientes.js"))
            //            {
            //                archivo = path;
            //                break;
            //            }
            //        }

            //        if (archivo != null)
            //        {
            //            datosRecuperados = JsonSerializer.Deserialize<List<Cliente>>(File.ReadAllText(archivo));
            //        }
            //    }

            //    listaClientes = datosRecuperados;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception($"Error en el archivo ubicado en {path}", ex);
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////









            this.Cargar();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                //FormModificarCliente formModificarCliente = new FormModificarCliente(this.listaClientes[index]);
                FormModificarCliente formModificarCliente = new FormModificarCliente((Cliente)this.listBox1.SelectedItem);
                formModificarCliente.ShowDialog();
                if (formModificarCliente.DialogResult == DialogResult.OK)
                {
                    this.listBox1.SelectedItem = formModificarCliente.cliente;
                }
            }
            this.Cargar();
        }

        private void Cargar()
        {
            this.listBox1.DataSource = null;
            this.dataGridView1.DataSource = null;
            this.listBox1.DataSource = this.listaClientes;
            this.dataGridView1.DataSource = this.listaClientes;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ShowDialog();
            if (formNuevoCliente.DialogResult == DialogResult.OK)
            {
                this.listaClientes.Add(formNuevoCliente.cliente);
                this.Cargar();
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                //MessageBox.Show(this.listaClientes[index].MostrarHistorial(), this.listaClientes[index].MostrarCliente());
                //string mensaje = this.listaClientes[index].MostrarCliente() + "\n";
                string mensaje = ((Cliente)this.listBox1.SelectedItem).MostrarCliente() + "\n";
                bool bandera = false;
                foreach (Pedido item in this.listaPedidos)
                {
                    if (item == this.listaClientes[index])
                    {
                        mensaje += item.MostrarPedido();
                        bandera = true;
                    }
                }
                if (!bandera)
                {
                    mensaje += "***** No se encuentran pedidos registrados *****";
                }
                FormMostrador formMostrador = new FormMostrador(mensaje);
                formMostrador.Show();
                //MessageBox.Show(mensaje);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorNombre.Text is not null && this.txtBuscarPorNombre.Text != string.Empty)
            {
                this.listBox1.FindString(this.txtBuscarPorNombre.Text);
                //this.listBox1.Items.Clear();
                //foreach (Cliente item in this.listaClientes)
                //{
                //    if ((item.Nombre.ToLower()).StartsWith(this.txtBuscarPorNombre.Text.ToLower()))
                //    {
                //        this.listBox1.Items.Add(item.ToString());
                //    }
                //}
            }
            else
            {
                this.Cargar();
            }
        }

        private void txtBuscarPorDireccion_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorDireccion.Text is not null && this.txtBuscarPorDireccion.Text != string.Empty)
            {
                this.listBox1.DataSource = null;
                this.dataGridView1.DataSource = null;
                List<Cliente> listita = new List<Cliente>();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Direccion.ToLower().StartsWith(this.txtBuscarPorDireccion.Text.ToLower()))
                    {
                        listita.Add(item);

                    }
                }
                this.listBox1.DataSource = listita;
                this.dataGridView1.DataSource = listita;
            }
            else
            {
                this.Cargar();
            }
        }

        private void txtBuscarPorTelefono_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscarPorTelefono.Text is not null && this.txtBuscarPorTelefono.Text != string.Empty)
            {
                this.listBox1.Items.Clear();
                foreach (Cliente item in this.listaClientes)
                {
                    if (item.Telefono.ToLower().StartsWith(this.txtBuscarPorTelefono.Text.ToLower()))
                    {
                        this.listBox1.Items.Add(item.ToString());
                    }
                }
            }
            else
            {
                this.Cargar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {








            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////


            //string nombreArchivo = path + "SerializandoJson_Clientes.js";
            //try
            //{
            //    if (!Directory.Exists(path))
            //    {
            //        Directory.CreateDirectory(path);
            //    }
            //    File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(listaClientes));

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception($"Error en el archivo ubicado en {path}", ex);
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////










            this.DialogResult = DialogResult.Cancel;
        }
    }
}
