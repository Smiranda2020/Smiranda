using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                foreach(string parametro in args)
                {
                    Console.WriteLine(parametro);
                }
            }
            ////int variable1, variable2, variable3, variable4;
            //int[] numeros= { 1, 2, 3, 4 };// inicializa la cantida de elementos
            //Circulo[] circulos = new Circulo[2]{ new Circulo(10), new Circulo(4) };
            //var arreglo = new[] { "hola","mundo" };
            //// tipo anonimo
            //var persona = new[]
            //{ new{nombre ="Hector"},
            //  new{nombre = "Luis"}
            //};
            ////accediendo a un elemento de un arreglo
            //try
            //{ 
            //int numero4 = numeros[3];
            //    Console.WriteLine(numero4);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Indice incorrecto");
            //}
            //int[] numeros = { 1, 3, 5, 9 };
            //for(int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            //foreach(int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}
            //101.Utilizando Arreglos en metodos
            //int[] numeros = Inicializar();
            //Console.WriteLine("Impresion de numeros");
            //foreach(int num in numeros)
            //{
            //    Console.WriteLine(num);
            //}
            //int[] arreglo = { 3, 5, 8, 9 };
            //int[] arreglo2 = arreglo;
            //Console.WriteLine(arreglo[0]);
            //Console.WriteLine(arreglo2[0]);
            //arreglo[0] = 25;
            //Console.WriteLine(arreglo[0]);
            //Console.WriteLine(arreglo2[0]);
            //Console.ReadLine();

            //Copiado de un arreglo
            //int[] arreglo = { 3, 5, 8, 9 };
            //int[] arreglo2 = new int[arreglo.Length];
            //Array.Copy(arreglo, arreglo2, arreglo.Length);

            //arreglo bidimencional
            int[,] bidimensional = new int[5, 5];
            bidimensional[0, 0] = 1;
            bidimensional[3, 3] = 10;
            Console.ReadLine();
        }
        static void GenerarReporte ()
        {
        }
        static int[]  Inicializar()
        {
            Console.WriteLine("Insgrese Cantidad");
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];
            for(var i=0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese valores");
                int valor = int.Parse(Console.ReadLine());
                numeros[i] = valor;
            }

            return numeros;
        }

    }
}
