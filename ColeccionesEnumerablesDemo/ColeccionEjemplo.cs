using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ColeccionEjemplo<T> : IEnumerable<T>
    {
        List<T> datos = new List<T>();
        public ColeccionEjemplo(params T[] _datos)
        {
            foreach(var dato in _datos)
            {
                datos.Add(dato);
            }
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            //Repasar implementacion 
            foreach(var dato in datos)
            {
                yield return dato;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
