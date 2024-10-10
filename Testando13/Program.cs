using System;
using Testando13;
using System.Globalization;

namespace Projeto {
    internal class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Enter the measurements of triangle X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measurements of triangle Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (x.A + x.B + x.C) / 2.0;
            double pY = (y.A + y.B + y.C) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));
            double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));


            Console.WriteLine("Area of X = " + areaX.ToString("F4"));
            Console.WriteLine("Area of Y = " + areaY.ToString("F4"));
            if (areaX > areaY) {
                Console.WriteLine("Larger area: X");
            }
            else {
                Console.WriteLine("Larger area: Y");
            }
        }
    }
}
