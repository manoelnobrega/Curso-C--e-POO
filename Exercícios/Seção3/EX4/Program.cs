using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EX4 {
    internal class Program {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.PI * Math.Pow(raio, 2.0);
            Console.WriteLine("A={0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
