using System;

namespace Seccion4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejemplo uso del switch");

            int dia = 3;

            switch (dia)
            {
                case 0:
                    Console.WriteLine("Lunes");
                    break;
                case 1:
                    Console.WriteLine("Martes");
                    break;
                case 2:
                    Console.WriteLine("Miercoles");
                    break;
                case 3:
                    Console.WriteLine("Jueves");
                    break;
                case 4:
                    Console.WriteLine("Viernes");
                    break;
                case 5:
                    Console.WriteLine("Sabado");
                    break;
                case 6:
                    Console.WriteLine("Domingo");
                    break;
                default: Console.WriteLine("El valor es incorrecto");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
