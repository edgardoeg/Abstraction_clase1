
namespace Abstraction_clase1
{
    public abstract class Figura
    {
        /// <summary>
        /// Abstract method that calculates the  geometric area
        /// </summary>
        /// <returns>Area value</returns>
        public abstract double Area();

        /// <summary>
        /// Abstract method that calculate the perimeter
        /// </summary>
        /// <returns>Perimeter value</returns>
        
        public abstract double Perimetro();
        /// <summary>
        /// print the area and perimeter values
        /// </summary>
        /// <returns name="NombreFigura"></returns>
        
        public void Imprimir(string NombreFigura)
        {
            Console.WriteLine($"Area del {NombreFigura}: {Area()}");
            Console.WriteLine($"Perimetro del {NombreFigura}: {Perimetro()}");
        }

    }
}
