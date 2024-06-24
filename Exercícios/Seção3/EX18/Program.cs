using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"{i} {Math.Pow(i, 2.0)} {Math.Pow(i, 3.0)}");
            }
        }
    }
}
