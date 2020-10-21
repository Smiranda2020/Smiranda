using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class DinamicFile : MultimediaFile
    {
        //public DinamicFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento) : base(_fechaCreacion, _fechaModificacion, _nombre, _tipoElemento)
        //{

        //}
        public virtual void Reproducir()
        {
            Console.WriteLine("Reproduciendo");
        }
        public virtual  void Pausar()
        {
            Console.WriteLine("Pausar");
        }
        public virtual void Detener()
        {
            Console.WriteLine("Detener");
        }

        public override void desplegarInformacion()
        {
            Console.WriteLine("Soy un archivo dinamico");
        }
        //public override  void desplegarInformacion()
        //{
        //    string informacion = fechaCreacion + "" + fechaModificacion + "" + nombre + "" + tipoElemento + "";
        //    Console.WriteLine(informacion);
        //}
        public override string obtenerTipo()
        {
            CalcularTamanio();
            string tarchivo = tipoArchivo;
            return "Archivo DinamicFile";
        }

    }
}
