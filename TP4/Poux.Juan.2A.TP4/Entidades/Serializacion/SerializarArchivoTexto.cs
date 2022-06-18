using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SerializarArchivoTexto
    {
        static string path;

        static SerializarArchivoTexto()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-TP3-Juan-Poux-1A\";
        }

        /// <summary>
        /// Crea un archivo de texto en la ruta definida
        /// </summary>
        /// <param name="nombre">nombre del archivo a crear</param>
        /// <param name="datos">texto que va a contener el archivo</param>
        public static void Escribir(string nombre, string datos)
        {
            string ubicacionYNombreArchivo = path + nombre + ".txt";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(ubicacionYNombreArchivo))
                {
                    sw.WriteLine(datos);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error guardando el archivo de texto en {path}", e);
            }
        }

        /// <summary>
        /// Si existe, lee el archivo y lo devuelve como string
        /// </summary>
        /// <param name="nombre">Nombre del archivo a leer</param>
        /// <returns>objeto o lista cargada con los datos</returns>
        public static string Leer(string nombre)
        {
            string ubicacionYNombreArchivo = string.Empty;
            nombre += ".xml";
            string datos = string.Empty;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            ubicacionYNombreArchivo = path;
                            break;
                        }
                    }
                    if (ubicacionYNombreArchivo != null)
                    {
                        datos = File.ReadAllText(ubicacionYNombreArchivo);
                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error leyendo el archivo ubicado en {path}", e);
            }
        }
    }
}
