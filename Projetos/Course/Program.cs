using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double px = (x.A + x.B + x.C) / 2;
            double py = (y.A + y.B + y.C) / 2;

            double areaX = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));
            double areaY = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            
            if (areaX > areaY) {
                Console.WriteLine($"Maior área: X");
            }
            else {
                Console.WriteLine($"Maior área: Y");
            }
        }
    }
}
