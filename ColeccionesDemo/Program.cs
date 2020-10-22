using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDemo
{  class Cliente
    {
        public int Id{ get; set; }
        public string nombre{ get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //174 174. El método Find, predicados y  Expresiones Lambda
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente
                {
                    Id = 2,
                    nombre ="Hector"
                },
                 new Cliente
                {
                    Id = 2,
                    nombre ="Ricardo"
                },
                 new Cliente
                {
                    Id = 3,
                    nombre ="Santiago"
                }
            };

            var cliente =clientes.Find((Cliente c) => 
            { 
                return c.Id == 3; 
            });
            if (cliente != null)
            {
                Console.WriteLine(cliente.nombre);
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }

            //173 Incicializacion de coleeciones// 174. El método Find, predicados y     Expresiones Lambda
            //List<string> lista = new List<string>
            //{
            //    "lista1",
            //    "lista2",
            //    "lista2",
            //    "lista2"
            //};
            //Dictionary<int, int> numero = new Dictionary<int, int>
            //{
            //    [0] = 1,
            //    [1] = 2,
            //};
            //Dictionary<string, string> nombre = new Dictionary<string, string>
            //{
            //    {"HP","Huilex Packar"},
            //    {"Cs","C Sharp"},
            //};

            //var valor = nombre["HP"];

            //172. La clase colección HashSet<T>
            //  HashSet<string> licenciatura1 = new HashSet<string>();
            //  licenciatura1.Add("Cocina");
            //  licenciatura1.Add("Negocio");
            //  licenciatura1.Add("Programacion");
            //  licenciatura1.Add("Postres");

            //  HashSet<string> licenciatura2 = new HashSet<string>() {"Programacion","Algoritmos","Postres","Base de datos" };
            ////foreach(var l in licenciatura1)
            ////  {
            ////      Console.WriteLine(l);
            ////  }
            //  //Metodo de comparacion, el resultado queda en la primera coleccion, con solo elementos repetidos
            //  licenciatura1.IntersectWith(licenciatura2);

            //  //Metodo de union, une las 2 colecciones
            //   licenciatura1.UnionWith(licenciatura2);

            //  //Metodo que devuelve los elementos que no tienen coaincidencia entre ambos
            //   licenciatura1.ExceptWith(licenciatura2);

            //  foreach (var l in licenciatura1)
            //  {
            //      Console.WriteLine(l);
            //  }

            //171. La clase colección SortedList<T>
            //SortedList<string, string> nombres = new SortedList<string, string>();
            //nombres.Add("a", "alberto");
            //nombres.Add("H", "hECTOR");
            //nombres.Add("B", "Braulio");
            //foreach (var elemento in nombres)
            //{
            //    var inicial = elemento.Key;
            //    var nombre = elemento.Value;
            //    Console.WriteLine($"{inicial},{nombre}");
            //}

            //170La clase colección  Dictionary<T>
            //int[] arreglo = new int[3] { 1, 2, 3 };
            //arreglo[0] = 20;
            //Dictionary<int, int> diccionario = new Dictionary<int, int>();
            //Dictionary<string, string> fraces = new Dictionary<string, string>();
            //fraces.Add("CP", "Alguna frase poetica");
            //fraces.Add("HP", "Curso C#");

            //foreach (var f in fraces)
            //{
            //    var key = f.Key;
            //    var valor = f.Value;
            //    Console.WriteLine($"{key},{valor}");
            //}
            //fraces["HP"] = "Curos Xamarin";
            //foreach (var f in fraces)
            //{
            //    var key = f.Key;
            //    var valor = f.Value;
            //    Console.WriteLine($"{key},{valor}");
            //}
            //Console.ReadLine();
            //for (var i =0; i<10;i++)
            //{
            //    diccionario.Add(i, i);
            //}

            // //169
            //  Stack <int> numeros = new Stack<int>();
            // numeros.Push(3);
            // //Console.WriteLine(numero);
            // for (int i = 1; i < 10; i++)
            // {
            //     numeros.Push(i);
            // }
            //// var elemento = numeros.Pop();
            // foreach (var numero in numeros)
            // {
            //     Console.WriteLine(numero);
            // }
            // Console.ReadLine();


            ////168 
            //Queue<int> numeros = new Queue<int>();
            //numeros.Enqueue(3);
            ////Console.WriteLine(numero);
            //for (int i = 1; i < 10; i++)
            //{
            //    numeros.Enqueue(i);
            //}
            //var elemento = numeros.Dequeue();
            //foreach (var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.ReadLine();





            //167. La clase colección LinkedList<T>
            //LinkedList<int> numeros = new LinkedList<int>();
            //numeros.AddLast(3);
            //for(int i=1; i<10;i++)
            //{
            //    numeros.AddLast(i);
            //}

            //foreach(var numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.ReadLine();

            //166 166. La clase colección List<T>
            //int[] arreglo = new int[10];
            //List<int> numerolista = new List<int>();
            //numerolista.Add(20);
            //for(int i =1; i<=10;i++)
            //{
            //    numerolista.Add(i);
            //}
            //numerolista.Insert(numerolista.Count - 1, 70);
            //numerolista.Remove(3);
            //numerolista.RemoveAt(0);
            //numerolista.RemoveRange(0, 3);
            ////numerolista.Clear();
            //int numero = numerolista[0];
            //foreach (int num in numerolista)
            //{
            //    Console.WriteLine(num);
            //}

            Console.ReadLine();
        }

        //174. El método Find, predicados y Expresiones Lambda
        static int HacerAlgo() 
        {
            return 1;
        }
    }
}
