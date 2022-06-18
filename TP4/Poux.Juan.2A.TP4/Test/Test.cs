using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace Test
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Testeo de agregar y buscar clientes en una lista
        /// </summary>
        [TestMethod]
        public void TestAgregoClienteYLoBusco_OK()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente cliente = new Cliente("1166035063", "Juan Poux", "Saavedra 352 2°C");

            listaClientes.Add(cliente);
            bool esta = false;
            foreach (Cliente item in listaClientes)
            {
                if (item == cliente)
                {
                    esta = true;
                    break;
                }
            }
            Assert.IsTrue(esta);
        }

        /// <summary>
        /// Testeo de modificacion de datos
        /// </summary>
        [TestMethod]
        public void TestModificoDatosDeCliente_OK()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente cliente = new Cliente("1166035063", "Juan Poux", "Saavedra 352 2°C");
            Cliente cliente1 = new Cliente("5566887744", "Pedro Perez", "Saavedra 352 2°C");

            cliente1.Nombre = "Juan Poux";

            Assert.IsTrue(cliente1 == cliente);
        }

        /// <summary>
        /// Testeo de igualdad de pedido con cliente correcto
        /// </summary>
        [TestMethod]
        public void TestIgualdadPedido_Cliente_OK()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente cliente = new Cliente("1166035063", "Juan Poux", "Saavedra 352 2°C");
            Cliente cliente1 = new Cliente("5566887744", "Pedro Perez", "Saavedra 352 2°C");
            Pedido pedido = new Pedido(cliente, true, DateTime.Now);

            Assert.IsTrue(pedido == cliente);
        }

        /// <summary>
        /// Testeo de igualdad de pedido con cliente incorrecto
        /// </summary>
        [TestMethod]
        public void TestIgualdadPedido_Cliente_Fail()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente cliente = new Cliente("1166035063", "Juan Poux", "Saavedra 352 2°C");
            Cliente cliente1 = new Cliente("5566887744", "Pedro Perez", "Saavedra 352 2°C");
            Pedido pedido = new Pedido(cliente, true, DateTime.Now);

            Assert.IsFalse(pedido == cliente1);
        }

        [TestMethod]
        public void TestConexionDB_Cliente_OK()
        {
            Assert.IsTrue(ClienteDao.ProbarConexion());
        }

        [TestMethod]
        public void TestAgregarDB_Cliente_OK()
        {
            Cliente cliente = new Cliente("11662255", "Carlos", "ASDASD");
            cliente.Activo = false;

            ClienteDao.Guardar(cliente);
        }

        [TestMethod]
        public void TestBorrarDB_Cliente_OK()
        {
            Cliente cliente = new Cliente("11662255", "Carlos", "ASDASD");
            cliente.Activo = false;
            cliente.Id = 7;

            ClienteDao.Eliminar(cliente.Id);
        }

        [TestMethod]
        public void TestModificarDB_Cliente_OK()
        {
            Cliente cliente = new Cliente("1166035063", "Juan Poux Morás", "Saavedra 352");
            cliente.Activo = false;
            cliente.Id = 1;

            ClienteDao.Modificar(cliente);
        }

        [TestMethod]
        public void TestLeerListaDB_Cliente_OK()
        {
            List<Cliente> lista = new List<Cliente>();

            lista = ClienteDao.Leer();
        }

        [TestMethod]
        public void TestLeerUnoDB_Cliente_OK()
        {
            Cliente cliente = null;

            cliente = ClienteDao.LeerPorId(1);

            Assert.IsTrue(true);
        }
    }
}
