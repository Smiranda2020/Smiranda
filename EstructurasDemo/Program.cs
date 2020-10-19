using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point? p = new Point();
            //Print(p);
            //StrutucPoint s1 = new StrutucPoint();
            //StrutucPoint s2 = s1;
            //Console.WriteLine(s1.X);
            //Console.WriteLine(s2.X);
            //s1.X++;
            //Console.WriteLine(s1.X);
            //Console.WriteLine(s2.X);

            ClassPoint  s1 = new ClassPoint();
            ClassPoint s2 = s1;
            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);
            s1.X++;
            Console.WriteLine(s1.X);
            Console.WriteLine(s2.X);
            Console.ReadLine();
            //Console.ReadLine();
        }
        //static void Print(Point? p)
        //{
        //    Console.WriteLine(p.Value.X);
        //}
    }
}
