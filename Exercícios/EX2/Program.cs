using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ult = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine(nome);
            Console.WriteLine(num);
            Console.WriteLine(num2.ToString("F2"));
            Console.WriteLine(ult);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
