using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClienteDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;
        static SqlDataReader lector;

        /// <summary>
        /// Constructor estatico con el nombre de mi servidor y base de datos
        /// </summary>
        static ClienteDao()
        {
            ClienteDao.cadenaConexion = @"Server=.;Database=Poux.Juan.2A.TPFinal;Trusted_Connection=True;";
            ClienteDao.conexion = new SqlConnection(ClienteDao.cadenaConexion);
        }

        /// <summary>
        /// Valida si hay conexion con la base de datos
        /// </summary>
        /// <returns></returns>
        public static bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                ClienteDao.conexion.Open();
            }
            catch (Exception ex)
            {
                rta = false;
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (ClienteDao.conexion.State == ConnectionState.Open)
                {
                    ClienteDao.conexion.Close();
                }
            }
            return rta;
        }

        /// <summary>
        /// Guarda un nuevo cliente en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public static void Guardar(Cliente cliente)
        {
            try
            {
                ClienteDao.comando = new SqlCommand();
                comando.Parameters.Clear();
                string sql = "INSERT dbo.Clientes ";
                sql += "(nombre,telefono,direccion,activo) VALUES(@nombre,@telefono,@direccion,@activo) ";

                ClienteDao.comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                ClienteDao.comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                ClienteDao.comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                ClienteDao.comando.Parameters.AddWithValue("@activo", cliente.Activo);
                ClienteDao.comando.CommandType = CommandType.Text;
                ClienteDao.comando.CommandText = sql;
                ClienteDao.comando.Connection = ClienteDao.conexion;
                ClienteDao.conexion.Open();
                ClienteDao.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (ClienteDao.conexion.State == ConnectionState.Open)
                {
                    ClienteDao.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Elimina un cliente de la base de datos
        /// </summary>
        /// <param name="id"></param>
        public static void Eliminar(int id)
        {
            try
            {
                ClienteDao.comando = new SqlCommand();
                comando.Parameters.Clear();

                ClienteDao.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.Clientes ";
                sql += "WHERE id = @id";

                ClienteDao.comando.CommandType = CommandType.Text;
                ClienteDao.comando.CommandText = sql;
                ClienteDao.comando.Connection = ClienteDao.conexion;
                ClienteDao.conexion.Open();
                ClienteDao.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (ClienteDao.conexion.State == ConnectionState.Open)
                {
                    ClienteDao.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Modifica un cliente de la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public static void Modificar(Cliente cliente)
        {
            try
            {
                ClienteDao.comando = new SqlCommand();

                comando.Parameters.Clear();

                string sql = "UPDATE dbo.Clientes ";
                sql += "SET nombre = @nombre, telefono = @telefono, direccion = @direccion, activo = @activo ";
                sql += "WHERE id = @id";

                ClienteDao.comando.Parameters.AddWithValue("@id", cliente.Id);
                ClienteDao.comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                ClienteDao.comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                ClienteDao.comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                ClienteDao.comando.Parameters.AddWithValue("@activo", cliente.Activo);

                ClienteDao.comando.CommandType = CommandType.Text;
                ClienteDao.comando.CommandText = sql;
                ClienteDao.comando.Connection = ClienteDao.conexion;

                ClienteDao.conexion.Open();
                ClienteDao.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (ClienteDao.conexion.State == ConnectionState.Open)
                {
                    ClienteDao.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Trae la lista completa de clientes de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> Leer()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                ClienteDao.comando = new SqlCommand();

                ClienteDao.comando.CommandType = CommandType.Text;
                ClienteDao.comando.CommandText = "SELECT * FROM dbo.Clientes ";
                ClienteDao.comando.Connection = ClienteDao.conexion;

                ClienteDao.conexion.Open();

                ClienteDao.lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    int id = lector.GetInt32(0);
                    string nombre = lector.GetString(1);
                    string telefono = lector.GetString(2);
                    string direccion = lector.GetString(3);
                    bool activo = lector.GetBoolean(4);
                    Cliente cliente = new Cliente(telefono, nombre, direccion);
                    cliente.Id = id;
                    cliente.Activo = activo;
                    lista.Add(cliente);
                }
                ClienteDao.lector.Close();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }

        /// <summary>
        /// Trae un solo cliente de la base de datos por el ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente LeerPorId(int id)
        {
            Cliente cliente = null;
            try
            {
                ClienteDao.comando = new SqlCommand();

                ClienteDao.comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Clientes WHERE id LIKE {id}";
                ClienteDao.comando.Connection = ClienteDao.conexion;
                conexion.Open();
                ClienteDao.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int ide = lector.GetInt32(0);
                    string nombre = lector.GetString(1);
                    string telefono = lector.GetString(2);
                    string direccion = lector.GetString(3);
                    bool activo = lector.GetBoolean(4);
                    cliente = new Cliente(telefono, nombre, direccion);
                    cliente.Id = ide;
                    cliente.Activo = activo;
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("No fue posible establecer conexion con el servidor de bases de datos", ex);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return cliente;
        }

    }
}
