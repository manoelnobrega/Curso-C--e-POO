using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1 {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medidas com oito casas decimais: {preco3:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {preco3:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {preco3.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
