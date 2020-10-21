using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionRecursosDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileManager manager1 = new FileManager(@"C:\Users\santiago.miranda\Documents\prueba.txt"))
            {
            }
            using (FileManager manager2 = new FileManager(@"C:\Users\santiago.miranda\Documents\prueba.txt"))
            {
            }

            //FileManager manager2 = new FileManager(@"C:\Users\santiago.miranda\Documents\prueba.txt");
            //Console.ReadLine();


        }
    }
}
