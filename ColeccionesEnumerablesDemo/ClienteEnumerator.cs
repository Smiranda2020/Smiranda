using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesEnumerablesDemo
{
    class ClienteEnumerator : IEnumerator
    {
        int position = -1;
        List<Cliente> clientes = null;
        public ClienteEnumerator(List<Cliente> _clientes)
        {
            clientes = _clientes;
        }
        public object Current 
        { get 
            {
                try
                {
                    return clientes[position];
                }
                catch(IndexOutOfRangeException )
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < clientes.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
