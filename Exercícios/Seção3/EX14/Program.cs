using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14 {
    internal class Program {
        static void Main(string[] args) {
            int cod = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (cod != 4) { 
                cod = int.Parse(Console.ReadLine());
                if (cod == 1) {
                    alcool++;
                }
                else if (cod == 2) {
                    gasolina++;
                }
                else if (cod == 3) {
                    diesel++;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
