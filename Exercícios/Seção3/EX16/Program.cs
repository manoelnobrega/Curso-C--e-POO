using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1;  i <= n; i++) {
                string[] v = Console.ReadLine().Split(' ');
                double x = double.Parse(v[0], CultureInfo.InvariantCulture);
                double y = double.Parse(v[1], CultureInfo.InvariantCulture);
                double z = double.Parse(v[2], CultureInfo.InvariantCulture);
                double media = ((x * 2) + (y * 3) + (z * 5)) / (2 + 3 + 5);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
