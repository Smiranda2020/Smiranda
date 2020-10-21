using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class figurDerivaAgain : FiguraDerivada
    {  //Podemos segir heredando los metodos override indefinidamente, para solucionar esto se usa sealed
        // quedo sellado y la clase figurDerivaAgain debe usar los metodos que se definio en la  clase FiguraDerivada
        //public override void ObtenerUbicacion()
        //{
        //    base.ObtenerUbicacion();
        //}
        //public override void ObtenerTop()
        //{
        //    base.ObtenerTop();
        //}
    }
    class FiguraDerivada : FiguraBase
    {  
        public sealed override  void ObtenerTop()
        {
            throw new NotImplementedException();
        }
        public sealed override  void ObtenerUbicacion()
        {
            base.ObtenerUbicacion();
        }
    }
    abstract class   FiguraBase
    {
        protected string colorFigura;
        public virtual void ObtenerUbicacion()
        {
            Console.WriteLine("X, y");
        }
        public abstract void ObtenerTop();
       
    
    }
}
