using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    class FileManager : IDisposable
    {
        FileStream reader = null;
        public FileManager(string filepath)
        {
            //try
            //{
            //    reader = File.Open(filepath, FileMode.Open);
            //    byte[] b = new byte[1024];
            //    //esta clase tiene un metodo que nos permite obtene una cadena de texto desde cada uno de lo s elementos de "b"
            //    //definido anteriormente.
            //    UTF8Encoding temp = new UTF8Encoding();

            //    throw new Exception();

            //    //Mientras podamos llevar a cabo la lectura de un caracter en el  archivo de texto while(reader.Read)
            //    //pasamo como parametros un array que es el buffer "b" un offset = 0 que es el desplazamiento en el array donde se colocara los bytes leides
            //    //por ultimo el numero maximo de byte que queremos leer b.length, mientras la operacion sea mayor a cero
            //    while (reader.Read(b, 0, b.Length) > 0)
            //    {
            //        //GetString decodifica los bytes de la matris de bytes especificada en una cadena
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    reader.Close();
            //}

            //137 La instruccion using y la interfas IDisposable

            //using (FileStream reader = File.Open(filepath, FileMode.Open)) 
            //{
            //    byte[] b = new byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding();

            //    while (reader.Read(b, 0, b.Length) > 0)
            //    {
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}

            //138 Implementando la interfaz IDisposable

            reader = File.Open(filepath, FileMode.Open);
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding();
            while (reader.Read(b, 0, b.Length) > 0)
            {
                //GetString decodifica los bytes de la matris de bytes especificada en una cadena
                Console.WriteLine(temp.GetString(b));
            }

        }
        ~FileManager()
        {
            System.Diagnostics.Trace.WriteLine("Archivo cerrado");
        }
        public void Dispose()
        {
            reader?.Dispose();
        }
    }
}
