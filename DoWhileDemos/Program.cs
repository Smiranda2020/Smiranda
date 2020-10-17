using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemos
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int suma = 0;
            do
            {
                suma += i;
                i++;
            }
            while (i < 10);

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
