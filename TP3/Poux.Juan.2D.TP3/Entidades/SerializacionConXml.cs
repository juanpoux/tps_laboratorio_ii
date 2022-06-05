using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializacionConXml<T> : IArchivos<T>
    {
        static string path;

        static SerializacionConXml()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-TP3-Juan-Poux-1A\";
        }

        public void Escribir(T datos, string nombre)
        {
            string ubicacionYNombreArchivo = path + nombre + ".xml";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(ubicacionYNombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, datos);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error serializando el archivo ubicado en {path}", e);
            }
        }

        public T Leer(string nombre)
        {
            string ubicacionYNombreArchivo = string.Empty;
            T datos = default;
            nombre += ".xml";
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
                        using (StreamReader streamReader = new StreamReader(ubicacionYNombreArchivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(streamReader);
                        }
                    }
                }
                else
                {
                    ubicacionYNombreArchivo = AppDomain.CurrentDomain.BaseDirectory + nombre;
                    if (File.Exists(ubicacionYNombreArchivo))
                    {
                        using (StreamReader streamReader = new StreamReader(ubicacionYNombreArchivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(streamReader);
                        }
                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error deserializando el archivo ubicado en {path}", e);
            }
        }
    }
}
