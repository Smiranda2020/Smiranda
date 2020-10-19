using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int valor1 = 50;
            //int valor2 = valor1;
            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            //valor1++;
            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);

            ////
            //Circulo cir1 = new Circulo();
            //cir1.radio = 50;
            //Circulo cir2 = cir1;

            //Console.WriteLine("Radio cir1 {0}",cir1.radio);
            //Console.WriteLine("Radio cir2 {0}", cir2.radio);

            //cir1.radio = 20;

            //Console.WriteLine("Radio cir1 {0}", cir1.radio);
            //Console.WriteLine("Radio cir2 {0}", cir2.radio);
            //int valor = 1;
            //agregarUno(valor);

            ////
            //Circulo circulo = new Circulo();
            //circulo.radio = 10;
            //agregarUno(circulo);

            //Console.WriteLine(circulo.radio);

            ////espacio se genera en el stack, es almacenado pero no inicializado
            //Circulo circulo2 = null;
            //Console.WriteLine(circulo2?.radio);
            //if (circulo2 == null)
            //{
            //    circulo2 = new Circulo();
            //}

            //Console.WriteLine(circulo2?.radio);

            ////circulo ahora si esta inicializdo
            //if (circulo != null)
            //{
            //    Console.WriteLine(circulo.radio);

            //}
            // Tipo de datos nulleable
            //int? i = null;
            //i = 10;
            //int? j = i;

            //if(!i.HasValue)
            //{
            //    i = 10;
            //}
            //else
            //{
            //    Console.WriteLine(i.Value);
            //}
            //int numer = 10;
            // ref hace que el valor persista una ves salido del metodo.

            //int numero2;
            //agregarUno(out numero2);
            //Console.WriteLine(numero2);

            //int.TryParse("50", out int pruebaconversionUno);
            //Console.WriteLine(pruebaconversionUno);

            //Object es el tipo de datos de la que heredan todas las clases en .Net System.object

            //object entero = 13;
            //object cadena = "Hola";

            //Boxin unboxing
            int valor = 50;

            //operacion de boxin, estamos llevando el valor de 50 al Heap
            //object objeto = valor;

            //Unboxing, llevamos la conversion de un object a un tipo de dato conocido en esta caso int.
            // int otrovalor = (int)objeto;
            object objeto = 40;
            if (objeto is int)
            {
                Console.WriteLine(objeto);
            }
           else if(objeto is string)
           {
                Console.WriteLine(objeto);
           }
            else if(objeto is Circulo)
            {
                Circulo circulo = (Circulo)objeto;
                Console.WriteLine(circulo.radio);

            }

            string valor2 = objeto as string;
            if(valor2 != null)
            {
                Console.WriteLine(valor2);
            }



            

            Console.ReadLine();
        }

        public static void agregarUno(out int param1)
        {
            param1 = 0;
            param1++;
        }

        public static void agregarUno(Circulo circulo)
        {
            //circulo = new Circulo();
            //circulo.radio = 50;
            circulo.radio++;
        }
    }
}
