using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{   
    //class HijaCirculo : Circulo
//    {
//no se puede heredar de una clase sellada
//    }
    sealed class Circulo : FiguraBase, IFigura , IRenderizador 
    {
        double radio;

        public double calculador()
        {
            throw new NotImplementedException();
        }

        public int Calcular(int x, int y)
        {
            return x + y;
        }

        public void CalcularArea()
        {
            throw new NotImplementedException();
        }

        void IRenderizador.Dibujar()
        {
            Console.WriteLine("Dibujar Circulo");
        }

        public void Renderizar()
        {
            throw new NotImplementedException();
        }

         void IFigura.Dibujar()
        {
            Console.WriteLine("Dibujar Circulo");
        }

        public override void ObtenerTop()
        {
            Console.WriteLine("Top");
        }
    }
}
