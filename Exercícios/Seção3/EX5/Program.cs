using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5 {
    internal class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valor;
            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine("SALARY = $ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
