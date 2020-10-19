using System;

namespace ClasesDemo1
{
    public class Rectangulo
    {
        private double baseRectangulo;
        private double alturaRectangulo;
        private string color;
        
        public  Rectangulo()
        {
             baseRectangulo = 15;
             alturaRectangulo = 3;
            color = "Negro";
        }
        public Rectangulo(double baseR, double alturaR)
        { 
            baseRectangulo = baseR;
            alturaRectangulo = alturaR;          
        }
        public void Deconstruct(out double baseR, out double alturaR)
        {
            baseR = baseRectangulo;
            alturaR = alturaRectangulo;
        }
        public double calcularPerimetro()
        {
            return (2 * alturaRectangulo) + (2 * baseRectangulo);
        }
        public static double calcularPerimetroRectangulo(double alturaRectangulo, double baseRectangulo)
        {
            return alturaRectangulo * baseRectangulo;
        }
        public double calcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }



    }
}
