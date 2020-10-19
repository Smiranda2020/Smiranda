using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class  Circulo  
    {   static int radio;
        public const double Pi = 3.14;
        public static int numerosCirculos;
        public  Circulo(int radioinicial)
        {
            radio = radioinicial;
            //campos compartidos
            numerosCirculos++;
        }
        public static double CalcularArea()
        {
            return (Math.PI * radio * radio);
        }
    }
}
