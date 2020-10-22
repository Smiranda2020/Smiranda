using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    class Program
    {
        static void Action1(int num1, int num2, int num3, int num4)
        {

        }
        static string func1()
        {
            return "Saludos";
        }
        static string func2(string s, int i, bool b)
        {
            return "Saludos";
        }

        static void Main(string[] args)
        {

            //186
            //List<int> numeros = new List<int>()
            //{
            //    20,
            //    133,
            //    89,
            //    23,
            //    78,
            //    382
            //};
            //var promedio = numeros.Average();
            //var c = numeros.Count(x =>x > 50 && x <100);
            //var suma = numeros.Sum(x => x % 2 == 0 ? x : 0);
            //Console.ReadLine();

            ////185
            //SistamasAlarmas alarmas = new SistamasAlarmas();
            //Action action = new Action(alarmas.EncenderAlarmas);
            //Action<int, int, int, int> action2 = new Action<int,int,int,int>(Action1);
            //Func<string> func = new Func<string>(func1);
            //Func<string, int, bool, string> funcion2 = new Func<string, int, bool, string>(func2);
            //184
            //List<string> nombres = new List<string>()
            //{
            //    "Luis",
            //    "Hector",
            //    "Santiago"
            //};
            //Predicate<string> predicado = new Predicate<string>(Contiene);
            //var resultado = nombres.Find(predicado);
            //Console.WriteLine(resultado);
            //Console.ReadLine();

            //181--187 nuevamente
            SistamasAlarmas alarmas = new SistamasAlarmas();
            SistemaLuces luces = new SistemaLuces();
            SistemasElectrodomesticos electrodomestico = new SistemasElectrodomesticos();

            CentralHub centraHub = new CentralHub();

            centraHub.Add(ApagarLuces);//esta son similare una usa adaptador y otra usa lambda
            centraHub.Add(() => luces.ApagarLuces(5));

            centraHub.Add(alarmas.EncenderAlarmas);
            centraHub.Add(electrodomestico.ApagarElectrodomenstico);
            //centraHub.IniciarProtocoloCierre();
            centraHub.ChecarSalida();
            centraHub.ChecarSalida();
            centraHub.ChecarSalida();
            centraHub.ChecarSalida();
            centraHub.ChecarSalida();
            Console.ReadLine();
        }
        static void ApagarLuces()
        {
            SistemaLuces luces = new SistemaLuces();
            luces.ApagarLuces(5);
        }
        static bool Contiene(string nombre)
        {
            return nombre.Contains("H");
        }
    }
}
