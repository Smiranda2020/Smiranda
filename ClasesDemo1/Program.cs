using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClasesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {  
            Rectangulo rectangulo = new Rectangulo(10,10);
            Rectangulo rectangulo2 = new Rectangulo();
            double area = rectangulo.calcularArea();
            double perimetro = rectangulo.calcularPerimetro();

            //invocando un metodo Deconstruct para optener valores de variables de clase.
            (var base1, var altura1) = rectangulo;

            //Invoca metodo estatico
            Console.WriteLine("Perimetro del rectangulo {0}",Rectangulo.calcularPerimetroRectangulo(10, 10));

            //Ejemplo de parametro en consola
            Console.WriteLine("Base es {0} la altura es {1}" , base1 , altura1);
            Console.WriteLine(rectangulo.calcularArea());

            //Usos de variables compartida
            Circulo circulo = new Circulo(10);
            Circulo circulo2 = new Circulo(20);
            Circulo circulo3 = new Circulo(30);

            Console.WriteLine("Cantidad de circulos creados {0}",Circulo.numerosCirculos);

            //Uso de constante, implicitamente statica
            WriteLine("Valor de Pi, definida como constante {0}",Circulo.Pi);

            //Clase anonima
            var objetoAnonimo = new { area = 5, campo2 = 5 };
            WriteLine(objetoAnonimo.area);
            Console.ReadLine();
            

        }
    }
}
