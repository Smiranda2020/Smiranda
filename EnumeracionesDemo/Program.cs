using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesDemo
{
    class Program
    {
        static void Main(string[] args)
        {   //***Roles**
            //Administrador -1
            //Desarrollador -2
            //UsuarioFinal -3

            //int tipoUsuario = 1;
            //switch(tipoUsuario)
            //{
            //    case 1: Console.WriteLine("Administrador");
            //        break;
            //    case 2: Console.WriteLine("Desarrollador");
            //        break;
            //    case 3: Console.WriteLine("UsuarioFinal");
            //        break;
            //    default: Console.WriteLine("Valor incorrecto");
            //        break;
            //}

            Rol tipoUsuario = Rol.Desarrollador;
            switch (tipoUsuario)
            {
                case Rol.Administrador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.Desarrollador:
                    Console.WriteLine(tipoUsuario);
                    break;
                case Rol.UsuarioFinal:
                    Console.WriteLine(tipoUsuario);
                    break;
                   }
            Console.ReadLine();
        }
    }
}
