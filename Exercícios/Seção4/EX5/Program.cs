using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario dados = new Funcionario();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            dados.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {dados}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            dados.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {dados}");
        }
    }
}
