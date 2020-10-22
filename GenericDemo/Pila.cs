using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Pila<T>
    {
        int tamanioDefault = 100;
        T[] arreglo = null;
        int IndiceActual = 0;
        int numElementos = 0;

       public  Pila()
        {
            arreglo = new T[tamanioDefault];
        }
        public  Pila(int _tamanio)
        {
            if(_tamanio >0)
            { 
            arreglo = new T[_tamanio];
            }
            else
            {
                throw new ArgumentException("El tamaño debe ser mayor a cero");
            }
        }
        public void Apilar(T _elemento)
        {
            if(numElementos == arreglo.Length)
            {
                throw new ArgumentException("El arreglo esta lleno");
            }
            arreglo[IndiceActual] = _elemento;
            IndiceActual++;
            numElementos++;

        }
        public object Desapilar()
        {
            if(IndiceActual == 0)
            {
                throw new ArgumentException("El elemento esta lleno");
            }
            IndiceActual--;
            var elemento = arreglo[IndiceActual];
            numElementos--;
            return elemento;
        }
    }
}
