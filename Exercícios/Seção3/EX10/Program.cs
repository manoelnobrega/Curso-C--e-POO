using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10 {
    internal class Program {
        static void Main(string[] args) {
            int cod = int.Parse(Console.ReadLine());
            int qtd = int.Parse(Console.ReadLine());
            double cq = 4.00;
            double xs = 4.50;
            double xb = 5.00;
            double trr = 2.00;
            double rf = 1.50;
            double preco = 0.00;
            if (cod == 1) {
                preco = cq * qtd;
            }
            else if (cod == 2) { 
                preco = xs * qtd;
            }
            else if (cod == 3) {
                preco = xb * qtd;
            }
            else if (cod == 4) {
                preco = trr * qtd;
            }
            else if (cod == 5) {
                preco = rf * qtd;
            }
            Console.WriteLine($"Total: R$ {preco:F2}");
        }
    }
}
