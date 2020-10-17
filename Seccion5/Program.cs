using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Seccion5
{

    class Program
    {
        static void Main()
        {
            //Operadores de accinacion compuesta
            string texto = "Programando ";
            Console.WriteLine(texto);
            texto += "con C#";
            Console.WriteLine(texto);
            string texto2 = "y .Net";
            texto += texto2;
            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
