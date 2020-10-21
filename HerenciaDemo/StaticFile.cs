using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class StaticFile : MultimediaFile 
    {
        //public StaticFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento): base(_fechaCreacion,  _fechaModificacion, _nombre, _tipoElemento)
        //{

        //}
        public override string obtenerTipo()
        {
            return "Archivo StaticFile";
        }

        public override void desplegarInformacion()
        {
            Console.WriteLine("Soy un archivo statico");
        }
        public virtual void editar()
        {
            Console.WriteLine("Editando");
        }
    }
}
