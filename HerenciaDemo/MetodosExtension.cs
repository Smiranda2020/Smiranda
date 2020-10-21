using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    static  class MetodosExtension
    {
        public static int contarPalabras(this string cadena)
        {
            var  palabras = cadena.Split(' ');
            return palabras.Length;
        }
    }
}
