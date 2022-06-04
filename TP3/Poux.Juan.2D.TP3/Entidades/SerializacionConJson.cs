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

        public T Leer(string nombre)
        {
            string archivo = string.Empty;
            T datosRecuperados = default;
            try
            {
                if (Directory.Exists(path))
                {
                    // recupera los nombres de los archivos que hay en esa carpeta incluida la ruta
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
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }
                else
                {
                    string ubicacionYNombreArchivo = AppDomain.CurrentDomain.BaseDirectory + nombre;
                    datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(ubicacionYNombreArchivo));
                }

                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

    }
}
