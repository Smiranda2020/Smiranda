using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class Linea : IFigura
    {
        double puntoXinicial;
        double puntoYinicial;
        double puntoXfinal;
        double puntoYfinal;

        public double calculador()
        {
            throw new NotImplementedException();
        }

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void CalcularArea()
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            Console.WriteLine("Dibujar Linea");
        }

    }
}
