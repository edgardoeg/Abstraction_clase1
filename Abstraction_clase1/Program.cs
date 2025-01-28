
using System.Drawing;
using Abstraction_clase1;

const string CIRCULO = "Circulo";
const string RECTANGULO = "rectangulo";

Circulo circulo = new Circulo(); 
Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Ingrese el radio:");
circulo.Radio= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la Base:");
rectangulo.Base = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la Altura: ");
rectangulo.Altura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Circulo: ");
circulo.Imprimir(CIRCULO);

Console.WriteLine();
Console.WriteLine("Rectangulo");
rectangulo.Imprimir(RECTANGULO);
