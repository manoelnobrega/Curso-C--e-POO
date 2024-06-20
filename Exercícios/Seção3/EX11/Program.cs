using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11 {
    internal class Program {
        static void Main(string[] args) {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x == 0.00 && y == 0.00) {
                Console.WriteLine("Origem");
            }
            else {
                if (x > 0) {
                    if (y > 0) {
                        Console.WriteLine("Q1");
                    }
                    else {
                        Console.WriteLine("Q4");
                    }
                }
                else {
                    if (y > 0) {
                        Console.WriteLine("Q2");
                    }
                    else {
                        Console.WriteLine("Q3");
                    }
                }
            }
        }
    }
}
