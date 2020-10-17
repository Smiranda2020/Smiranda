using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones1Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEnCadena = Console.ReadLine();
            try
            {
                int valor = int.Parse(numeroEnCadena);
                Console.WriteLine(valor / 0);
               
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Solo debe ingresar números");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadLine();

        }
    }
}
