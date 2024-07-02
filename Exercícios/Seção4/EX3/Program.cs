using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3 {
    internal class Program {
        static void Main(string[] args) {
            Produto cliente;
            cliente = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            cliente.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            cliente.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {cliente}");
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            cliente.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {cliente}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            cliente.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {cliente}");
        }
    }
}
