using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclosFor
{
    class Program
    {
        static void Main()
        {
            for(int i = 0 ; i<=10; i++ )
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Segundo ejemplo ");

            for (int i = 0, j=10; i < j;i++, j--)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
