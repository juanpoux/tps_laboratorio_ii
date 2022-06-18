using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializacionConJson<T> : IArchivos<T>
    {
        static string path;

        static SerializacionConJson()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-TP3-Juan-Poux-1A\";
        }

        /// <summary>
        /// Crea un archivo JSON en la ruta definida y convierte a formato JSON el objeto o lista que recibe por parametro
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombre"></param>
        public void Escribir(T datos, string nombre)
        {
            string nombreArchivo = path + nombre + ".json";
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos, opciones));
            }
            catch (Exception e)
            {
                throw new Exception($"Error serializando el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Si existe, lee el archivo JSON y lo devuelve en formato objeto o lista
        /// </summary>
        /// <param name="nombre">nombre del archivo a leer</param>
        /// <returns>objeto o lista cargada con los datos</returns>
        public T Leer(string nombre)
        {
            string archivo = string.Empty;
            T datos = default;
            nombre += ".json";
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        datos = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }
                else
                {
                    string ubicacionYNombreArchivo = AppDomain.CurrentDomain.BaseDirectory + nombre;
                    if (File.Exists(ubicacionYNombreArchivo))
                    {
                        datos = JsonSerializer.Deserialize<T>(File.ReadAllText(ubicacionYNombreArchivo));
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en deserializando el archivo ubicado en {path}", e);
            }
        }
    }
}
