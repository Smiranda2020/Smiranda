using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    interface  IFigura : ICalculador 
    {
        void Dibujar();
        int Calcular(int x, int y);
  
    }
}
