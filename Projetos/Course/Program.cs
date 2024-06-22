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
            Console.WriteLine("Digite três números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double resul = Maior(a, b, c);
            Console.WriteLine($"Maior = {resul}");

        }

        static int Maior(int n1, int n2, int n3) {
            int m;
            if (n1 > n2 && n1 > n3) {
                m = n1;
            }
            else if (n2 > n3) { 
                m = n2;
            }
            else {
                m = n3;
            }
            return m;
        }
    }
}
