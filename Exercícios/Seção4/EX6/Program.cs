using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6 {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Notas();

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(aluno);
        }
    }
}
