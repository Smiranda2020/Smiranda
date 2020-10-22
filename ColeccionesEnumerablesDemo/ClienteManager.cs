using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColeccionesEnumerablesDemo
{
    class ClienteManager : IEnumerable
    {
        List<Cliente> clientes;
        public ClienteManager()
        {
            clientes = new List<Cliente>()
            {
                new Cliente {Id=1,nombre= "Hector"},
                new Cliente {Id=2,nombre= "Ricardo"},
                new Cliente {Id=3,nombre= "Lis"},
                new Cliente {Id=4,nombre= "Cris"},

            };


        }

        public IEnumerator GetEnumerator()
        {
            return new ClienteEnumerator(clientes);
        }
    }
}
