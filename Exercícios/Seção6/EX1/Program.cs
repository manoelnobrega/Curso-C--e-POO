using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EX1 {
    internal class Program {
        static void Main(string[] args) {
            int quarto, n, i;
            string nome, email;
            Aluguel[] pousada = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                pousada[quarto] = new Aluguel(nome, email);

            }

            Console.WriteLine("Quartos Ocupados:");
            for (i = 0; i < 10; i++) {
                if (pousada[i] != null) {
                    Console.Write($"{i}: ");
                    Console.WriteLine(pousada[i]);
                }
            }

        }
    }
}
