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
            double raio, circ, vol;

            Console.Write("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            circ = Calculadora.Circunferencia(raio);
            vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
