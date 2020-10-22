using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    interface Iinterfas<T>
    {
        T dato{ get; set; }
    }
    struct  StruturaGeneriaca<T>
    {
        T dato;
    }
    class ClaseGenerica<T,U>  where T : Exception 
    {
        T dato;
        U dato2;
        public  ClaseGenerica(T _dato)
        {
            dato = _dato;
        }

        //public T hacerAlgo(T _dato)
        //{
        //    T dato = _dato;
        //    return dato;
        //}

        public void  hacerAlgo(T dato)
        {
            //esto es posible ya que T Esta restringido a la Clase Expetion
            //class ClaseGenerica<T,U>  where T : Exception 
            Console.WriteLine(dato.Message);
        }
    }
}
