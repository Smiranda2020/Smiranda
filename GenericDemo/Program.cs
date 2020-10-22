using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //157
            //Pila pila = new Pila(3);
            //pila.Apilar(1);
            //pila.Apilar(2);
            //pila.Apilar("Hola");
            //object elemento = pila.Desapilar();
            //Console.WriteLine(elemento);
            // elemento = pila.Desapilar();
            //Console.WriteLine(elemento);
            // elemento = pila.Desapilar();
            //Console.WriteLine(elemento);

            //Circulo circulo = new Circulo();
            //pila.Apilar(circulo);
            //elemento = pila.Desapilar();
            //Console.WriteLine(elemento);

            //  //158//161
            //  ClaseGenerica<ArgumentOutOfRangeException,string> g = new ClaseGenerica<ArgumentOutOfRangeException, string>(new ArgumentOutOfRangeException());
            ////  g.hacerAlgo(3);
            //  ClaseGenerica<Exception , Circulo > g2 = new ClaseGenerica<Exception , Circulo >(new Exception(""));
            ////  g2.hacerAlgo("Hola");
            ///
            //162
            //string cadena = "hola";
            //Dato<string> dato = new Dato<string>();
            //IDato<string> datoTemporal = dato;
            //datoTemporal.setDato("Hola");
            //Console.WriteLine(datoTemporal.getDato());

            //163
            //Dato<string> dato = new Dato<string>();
            //IAlmacenador<string> almacenador = dato;

            //IObtenedor<object> obtenedor = dato;
            //almacenador.setDato("HolaP");

            //Console.WriteLine(obtenedor.getDato());
            //Console.ReadLine();

            //164 Interfaces contravarianza
            object x = 33;
            object y = 44;
            ComparadorObjetos comparadorobjetos = new ComparadorObjetos();
            IComparer<object> icomparador = comparadorobjetos;
            int resultado = icomparador.Compare(x, y);
            Console.WriteLine(resultado);
            Console.ReadLine();


        }
    }
}
