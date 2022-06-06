using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializer
    {
        private static string rutaBase;

        static Serializer()
        {
            DirectoryInfo ruta = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Flash_Imports\\");
            Serializer.rutaBase = ruta.FullName;
        }


        public static void SerializarPersona(string fileName, Persona persona)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Serializer.rutaBase}{fileName}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xml.Serialize(streamWriter, persona);

            }
        }
        public static void SerializarVehiculo(string fileName, Vehiculo vehiculo)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Vehiculo));
                    xml.Serialize(streamWriter, vehiculo);
                } catch(SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void SerializarSucursal(string fileName, Sucursal sucursal)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Sucursal));
                    xml.Serialize(streamWriter, sucursal);
                }
                catch (SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void Serializar_XmlTextWriter(string fileName, Persona persona)
        {

            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Serializer.rutaBase}{fileName}", Encoding.UTF8))
            {
                try {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    xmlTextWriter.Formatting = Formatting.Indented;
                    xml.Serialize(xmlTextWriter, persona);
                }catch (SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public static void Serializar_XmlTextWriter(string fileName, Vehiculo vehiculo)
        {

            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Serializer.rutaBase}{fileName}", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    xmlTextWriter.Formatting = Formatting.Indented;
                    xml.Serialize(xmlTextWriter, vehiculo);
                }
                catch (SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        public static void Serializar_XmlTextWriter(string fileName, Sucursal vehiculo)
        {

            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Serializer.rutaBase}{fileName}", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    xmlTextWriter.Formatting = Formatting.Indented;
                    xml.Serialize(xmlTextWriter, vehiculo);
                }
                catch (SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public static Persona Deserializar_StreamReader(string fileName)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    Persona persona = xml.Deserialize(streamReader) as Persona;
                    return persona;
                }catch(SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }

                return null;
            }

        }
        public static Persona Deserializar_XmlTextReader(string fileName)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    Persona persona = xml.Deserialize(xmlTextReader) as Persona;
                    return persona;
                } catch(SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }

        }

        public static void Serializar_JSON(string fileName, Empleado empleado)
        {
            using (StreamWriter streamWriter = new StreamWriter($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(empleado, options);
                    streamWriter.WriteLine(ser);
                }catch(SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static Empleado DesSerializar_JSON(string fileName)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializer.rutaBase}{fileName}"))
            {
                try
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<Empleado>(json);
                }catch(SerializerException e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
        }
    }
}
