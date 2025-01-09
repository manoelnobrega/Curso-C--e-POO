using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EX1 {
    internal class Program {
        static void Main(string[] args) {
            int Num;
            string Nome;
            char Opc;
            double Valor = 0.0;
            ContaBancaria conta;
            double dep, saq;

            Console.Write("Entre com o número da conta: ");
            Num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            Opc = char.Parse(Console.ReadLine());
            if (Opc == 's' || Opc == 'S') {
                Console.Write("Entre com valor do depósito inicial: ");
                Valor = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(Num, Nome, Valor);
            }
            else {
                conta = new ContaBancaria(Num, Nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para depósito: ");
            dep = double.Parse(Console.ReadLine());
            conta.Deposito(dep);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para saque: ");
            saq = double.Parse(Console.ReadLine());
            conta.Saque(saq);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
