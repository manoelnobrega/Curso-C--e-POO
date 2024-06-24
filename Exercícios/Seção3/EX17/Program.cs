using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = n;  i > 0; i--) {
                fat *= i;
            }
            Console.WriteLine(fat);
        }
    }
}
