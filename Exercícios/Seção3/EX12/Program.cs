﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12 {
    internal class Program {
        static void Main(string[] args) {
            int senha = 0;
            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002) {
                    Console.WriteLine("Senha Invalida");
                }
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
