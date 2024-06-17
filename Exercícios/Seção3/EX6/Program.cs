using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6 {
    internal class Program {
        static void Main(string[] args) {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(p1[0]);
            int cod2 = int.Parse(p2[0]);
            int n1 = int.Parse(p1[1]);
            int n2 = int.Parse(p2[1]);
            double valor1 = double.Parse(p1[2], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(p2[2], CultureInfo.InvariantCulture);
            double preco = (n1 * valor1) + (n2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
