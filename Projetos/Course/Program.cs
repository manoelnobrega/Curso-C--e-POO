using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Course {
    internal class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            char crc = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] linha = Console.ReadLine().Split(' ');
            string nome = linha[0];
            char sexo = char.Parse(linha[1]);
            int idade = int.Parse(linha[2]);
            double altura = double.Parse(linha[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(crc);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} {sexo} {idade} {altura:F2}");
        }
    }
}
