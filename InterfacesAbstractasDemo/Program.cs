using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        { //118
            
            Circulo circulo = new Circulo();
            Linea linea = new Linea();
            linea.Dibujar();
            //  circulo.Dibujar();
            circulo.ObtenerUbicacion();
            Console.ReadLine();

            
        }
        static void CalcularArea(IFigura figura)
        {
            if (figura is Circulo)
            {
                figura.Dibujar();
            }
            else if (figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}
