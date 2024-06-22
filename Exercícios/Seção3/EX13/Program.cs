using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13 {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            while (x != 0 && y != 0) {
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("primeiro");
                    }
                    else {
                        Console.WriteLine("quarto");
                    }
                }
                else {
                    if (y > 0) {
                        Console.WriteLine("segundo");
                    }
                    else {
                        Console.WriteLine("terceiro");
                    }
                }
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
