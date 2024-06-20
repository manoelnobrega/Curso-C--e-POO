using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9 {
    internal class Program {
        static void Main(string[] args) {
            int h1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int hora = 0;
            if (h2 > h1) {
                hora = h2 - h1;
            }
            else if (h2 == h1) {
                hora = 24;
            }
            else {
                hora = (24 - h1) + h2;
            }
            Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
        }
    }
}
