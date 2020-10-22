using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventosDemo
{
    public class CentralHub
    {
        //187
        ControlEmpleados control = new ControlEmpleados();



        //instanciar el delegado
      //  public iniciarProtocoloDelegare iniciarProtocolo;

        //183
        //SistamasAlarmas alarmas = new SistamasAlarmas();
        //SistemaLuces luces = new SistemaLuces();
        //SistemasElectrodomesticos electrodomesticos = new SistemasElectrodomesticos();
        ////public CentralHub()

        //{   //cuando asigna atraves de += no es necesario en los metodos()
        // aca estamo indicando que el delegado esta haciendo referencia al metodo apagarLuces
        //iniciarProtocolo += luces.ApagarLuces;
        //iniciarProtocolo += alarmas.EncenderAlarmas;
        //iniciarProtocolo += electrodomesticos.ApagarElectrodomenstico;

        //Otra forma de inicializar
        //iniciarProtocolo = new iniciarProtocoloDelegare(luces.ApagarLuces);
        // }
        public void IniciarProtocoloCierre()
        {
            //iniciarProtocolo();
            //alarmas.EncenderAlarmas();
            //electrodomesticos.ApagarElectrodomenstico();
        }
        public void Add(Action  metodoProtocolo) =>
          control.EmpleadosCero  += metodoProtocolo;

        public void Remove(Action metodoProtocolo) =>
        control.EmpleadosCero -= metodoProtocolo;

        public void ChecarSalida()
        {
            control.checarSalida();
        }
    }
}
