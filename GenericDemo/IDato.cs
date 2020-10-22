using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{   //163
    class Dato<T> : IAlmacenador<T>, IObtenedor<T>
    {
        T dato;

        void IAlmacenador<T>.setDato(T _dato)
        {
            dato = _dato;
        }

        T IObtenedor<T>.getDato()
        {
            return dato;
        }

    }

    //162
    //class Dato<T> : IDato<T>
    //{
    //    T dato;
    //    T IDato<T>.getDato()
    //    {
    //        return dato;
    //    }

    //    void IDato<T>.setDato(T _dato)
    //    {
    //        dato = _dato;
    //    }
    //}
    interface IDato<T>
    {
        void setDato(T _dato);
        T getDato();
    }

    interface IAlmacenador<T>
    {
        void setDato(T _dato);
        
    }
    interface IObtenedor<out T>
    {
        T getDato();
    }
}
