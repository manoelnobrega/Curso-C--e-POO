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
            int n, i, id, aumento, aux;
            string nome;
            double salario, porcentagem;
            Funcionario funcionario, verificacao;
            List<Funcionario> listaFunc = new List<Funcionario>();


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

            }

            Console.Write("Digite o id do funcionario que vai receber um aumento salarial: ");
            aumento = int.Parse(Console.ReadLine());
            verificacao = listaFunc.Find(x => x.ID == aumento);
            if (verificacao.ID != aumento) {
                Console.WriteLine("Este id não existe!");
            }
            else {
                aux = listaFunc.FindIndex(x => x.ID == aumento);
                Console.Write("Digite a porcentagem: ");
                porcentagem = double.Parse(Console.ReadLine());
                



        }

    }
}
