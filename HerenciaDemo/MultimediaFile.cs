using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile : System.Object
    {   string fechaCreacion;
        string fechaModificacion;
        string nombre;
        string tipoElemento;
        protected string tipoArchivo;
       
        //public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        //{
        //    fechaCreacion = _fechaCreacion;
        //    fechaModificacion = _fechaModificacion;
        //    nombre = _nombre;
        //    tipoElemento = _tipoElemento;
        //}
        public virtual string  obtenerTipo()
       {
            return "Archivo Multimedio";
       }


        public virtual void  desplegarInformacion()
        {
            string informacion = fechaCreacion + "" + fechaModificacion + "" + nombre + "" + tipoElemento + "";
            Console.WriteLine(informacion);
        }
        public override  string ToString()
        {
            CalcularTamanio();//modo demostrativo, tenemos acceso desde nuestra clase, con/sin la protected
            return "ToString Sobrescrito";
        }

        protected void CalcularTamanio()
        {

        }

    }
}
