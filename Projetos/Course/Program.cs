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
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write($"Valor #{i}: ");
                int a = int.Parse(Console.ReadLine());
                soma += a;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
