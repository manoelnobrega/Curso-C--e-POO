﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            int a = 1;
            while (a >= 0) {
                Console.WriteLine("Digite um número:");
                a = int.Parse(Console.ReadLine());
                
                double raiz = Math.Sqrt(a);
                Console.WriteLine($"{raiz:F3}");
            }
            Console.WriteLine("Número negativo!");
        }
    }
}
