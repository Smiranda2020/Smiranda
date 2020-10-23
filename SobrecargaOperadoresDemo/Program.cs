using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadoresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();
            Rectanguro r = new Rectanguro();
            var resultado = c + r;
            var resultado2 = c + 20;
            var resultado3 = 20 + r;
         
           Console.WriteLine(r.area);
           r = c;
            Console.WriteLine(c.area);
            Console.ReadLine();
            //    c += c;
            //    Console.WriteLine(c.area);
            //    c = c + c;
            //    Console.WriteLine(c.area);
            //    c++;
            //    Console.WriteLine(c.area);
            //    Console.ReadLine();
        }
        public abstract class figura
        {
            public double area { get; set; }
            public abstract void CalcuarArea();
            public figura()
            {
                CalcuarArea();
            }
            public static double operator +(figura lhs, int rhs) =>
               lhs.area + rhs;
            public static double operator +(figura lhs, figura rhs) =>
            lhs.area + rhs.area;
            public static double operator +(int lhs, figura rhs) =>
            lhs + rhs.area;
        }

        public class Circulo : figura
        {
            public override void CalcuarArea()
            {
                area = 50;
            }
            public static Circulo operator +(Circulo lhs, Circulo rhs) =>
            new Circulo { area = lhs.area + rhs.area };

            public static Circulo operator ++(Circulo circulo)
            {
                circulo.area++;
                return circulo;
            }

            public static bool operator ==(Circulo lhs, Circulo rhs) =>
             lhs.area == rhs.area;

            public static bool operator !=(Circulo lhs, Circulo rhs) =>
            lhs.area == rhs.area;

            public static bool operator <=(Circulo lhs, Circulo rhs) =>
            lhs.area <= rhs.area;

            public static bool operator >=(Circulo lhs, Circulo rhs) =>
            lhs.area >= rhs.area;

            public static implicit operator Rectanguro(Circulo circulo) =>
             new Rectanguro{area = circulo.area };
        }

        public class Rectanguro : figura
        {
            public override void CalcuarArea()
            {
                area = 100;
            }

        }
    }
}
