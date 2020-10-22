using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    public class ControlEmpleados
    {
        //public delegate void iniciarProtocoloDelegare();
        public event Action EmpleadosCero;
        int numerEmpleado = 5;
        public void checarSalida()
        {
            numerEmpleado--;
            if(numerEmpleado ==0)
            {
                if(EmpleadosCero != null)
                {
                    EmpleadosCero();
                }
            }
            else
            {
                Console.WriteLine($"Quedan {numerEmpleado} empleados");
            }
        }
    }
}
