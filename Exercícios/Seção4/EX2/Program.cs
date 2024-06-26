using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.salario + f2.salario) / 2.00;
            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
