using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cadena = new List<string>();
            ClienteManager manager = new ClienteManager();
            foreach(Cliente  cliente in manager)
            {
                Console.WriteLine(cliente.nombre);
            };
            var enumerator = manager.GetEnumerator();
            while(enumerator.MoveNext() )
            {
                Console.WriteLine(((Cliente)enumerator.Current).nombre);
            }
            Console.ReadLine();
        }
    }
}
