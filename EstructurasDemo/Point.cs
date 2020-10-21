using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDemo
{
    //La estructura es util cuando es mas importante la informacion(propiedades) que contenga el objeto que se quiere representar
    // una estructura no puede lleva a cabo el concepto de herencia  
    struct StrutucPoint
    { //En las estructuras no se puede inicializar los campos desde su definicion, en las clases si se puede.
      //int X = 0;
      //int Y= 0;
        public int X;
        int Y;
        public StrutucPoint(int x, int y)
        {
            X = x;
            Y =  y; 
        }

        public  int Calcular()
        {
            return X * Y;
        }
    }

    class ClassPoint
    {
    public int X;
    public int Y;
    }
}
