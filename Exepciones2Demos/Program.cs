using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones2Demos
{
    class Program
    {
        static void Main()
        {
            int mes = int.Parse(Console.ReadLine());
            // obtenerSignoSodiacal(mes);
            try
            {
                Console.WriteLine(obtenerSignoSodiacal(mes));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadLine();
        }
        static string obtenerSignoSodiacal(int NumeroMes)
        {
            string resultado = string.Empty;
            switch(NumeroMes)
            {
                case 1:
                    resultado = "Acuario";
                    break;
                case 2:
                    resultado = "Pisis";
                    break;
                case 3:
                    resultado = "Aries";
                    break;
                case 4:
                    resultado = "Geminis";
                    break;
                case 5:
                    resultado = "Cancer";
                    break;
                case 6:
                    resultado = "Leo";
                    break;
                case 7:
                    resultado = "Leo";
                    break;
                case 8:
                    resultado = "Libra";
                    break;
                case 9:
                    resultado = "Libra";
                    break;
                case 10:
                    resultado = "Capricornio";
                    break;
                case 11:
                    resultado = "Acuario";
                    break;
                case 12:
                    resultado = "Pisis";
                    break;
                default:
                    throw new InvalidOperationException("Mes Invalido");
            }
            return resultado;
        }
    }
}
