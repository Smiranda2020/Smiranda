using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arreglo = { 2, 4, 6, 8, 10 };
            int suma = sumar(1, 2, 3, 4, 5, 6, 7, "8", 9, "100");
            Console.ReadLine();
        }
        //static int Sumar(int numero1, int numero2)
        //{
        //    return numero1 + numero2;
        //}
        //static int sumar (int[] numeros), la palabra params es la unica diferencia
        //solo para array unidimensional
        // param debe ser el ultimo parametro de una lista de parametros formales, tampoco soport ref ni out.
        //static int sumar(params int[] numeros)
        //{

        //    if (numeros.Length < 2 || numeros == null)
        //    {
        //        throw new ArgumentException("Debe argregar 2 parametros como minimo");
        //    }
        //    else
        //    {
        //        int suma = 0;
        //        foreach (var n in numeros)
        //        {
        //            suma += n;
        //        }
        //        return suma;
        //    }
        //}
        static int sumar( params object[] numeros)
        {
            int suma = 0;
            if(numeros.Length <2 || numeros == null)
            {
                throw new ArgumentException("Debe argregar 2 parametros como minimo");
            }
            else
            {
                foreach(var num in numeros)
                {
                    if(num is int)
                    {
                        suma+= (int)num; //esto es por que en estos momentos num es un objeto, debo agregar(int)
                    }
                    else if(num is string)
                    {
                        bool convertido = int.TryParse((string)num, out int temporal);
                        if(convertido)
                        {
                            suma += temporal;
                        }
                        else
                        {
                            throw new ArgumentException("Valor no valido");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Valor no valido");
                    }

                }
                return suma;
            }
        }
    }
}
