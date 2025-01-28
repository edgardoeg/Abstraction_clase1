

namespace Abstraction_clase1
{
    public class Rectangulo : Figura
    {
        public double Base;
        public double Altura;

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 + (Base * Altura);
        }
    }
}
