using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultimediaFile mfile = new MultimediaFile("12/12/2018", "12/12/2018","Nuevo archivo Multimedia","Video");
            MultimediaFile mfile = new MultimediaFile();

            mfile.desplegarInformacion();
            Console.WriteLine(mfile);
            mfile.ToString();

            //DinamicFile dFile = new DinamicFile("12/12/2018", "12/12/2018", "Nuevo archivo DinamicFile", "Video");
            DinamicFile dFile = new DinamicFile();
            dFile.Reproducir();
            dFile.Pausar();
            dFile.desplegarInformacion();
            
            //StaticFile sFile = new StaticFile("12/12/2018", "12/12/2018", "Nuevo archivo StacitFile", "Video");
            StaticFile sFile = new StaticFile();
            sFile.desplegarInformacion();
            sFile.editar();
            MultimediaFile mfile2 = dFile;

            //Polimorfismo
            MultimediaFile multimedia;
            DinamicFile dfile = new DinamicFile();
            StaticFile sfile = new StaticFile();
            OtherFile ofile = new OtherFile();

            multimedia = dfile;
            Console.WriteLine(multimedia.obtenerTipo());

            multimedia = sfile;
            Console.WriteLine(multimedia.obtenerTipo());

            multimedia = ofile;
            Console.WriteLine(multimedia.obtenerTipo());

            //Metodo de extension

            string palabra = "esto es una pruba";
            var cantidad1 = MetodosExtension.contarPalabras(palabra);
            var cantidad2 = palabra.contarPalabras();

            Console.WriteLine(cantidad1);
            Console.WriteLine(cantidad2);


            Console.ReadLine();
            


        }
    }
}
