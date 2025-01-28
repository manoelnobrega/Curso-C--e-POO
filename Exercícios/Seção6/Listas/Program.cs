using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args) {
            int n, i, id, aumento;
            string nome;
            double salario, porcentagem;
            Funcionario funcionario, verificacao;
            List<Funcionario> listaFunc = new List<Funcionario>(); // Lista dos funcionários

            // Registro dos funcionários
            Console.Write("Quantos funcionários serão registrados? ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++) {
                Console.WriteLine($"Funcionário #{i + 1}:");
                Console.Write($"Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write($"Nome: ");
                nome = Console.ReadLine();
                Console.Write($"Salário: ");
                salario = double.Parse(Console.ReadLine());

                funcionario = new Funcionario(id, nome, salario);
                listaFunc.Add(funcionario);
                Console.WriteLine();
            }

            // Aumento Salarial
            Console.WriteLine();
            Console.Write("Digite o id do funcionario que vai receber um aumento salarial: ");
            aumento = int.Parse(Console.ReadLine());
            verificacao = listaFunc.Find(x => x.ID == aumento);
            if (verificacao == null) {
                Console.WriteLine("Este id não existe!");
            }
            else {
                Console.Write("Digite a porcentagem: ");
                porcentagem = double.Parse(Console.ReadLine());

                foreach (Funcionario func in listaFunc) {
                    if (func == verificacao) {
                        func.AumentarSalario(porcentagem);
                    }
                }

            }

            // Lista dos Funcionários
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Funcionario func in listaFunc) {
                Console.WriteLine(func);
            }

        }

    }
}
