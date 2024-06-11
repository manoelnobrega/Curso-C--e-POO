using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            int idade = 22;
            float saldo = 269.7542f;
            string nome = "Manoel";

            Console.WriteLine(saldo.ToString(CultureInfo.InvariantCulture)); // com ponto no lugar da vírgula
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2}R$", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}R$");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + "R$"); // concatenando strings
        }
    }
}
