using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7 {
    internal class Program {
        static void Main(string[] args) {
            double cotacao;
            double dolares;
            double valorFinal;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            dolares = double.Parse(Console.ReadLine());

            valorFinal = ConversorDeMoeda.CalculoDolarReal(cotacao, dolares);
            Console.WriteLine($"Valor a ser pago em reais: {valorFinal}");

        }
    }
}
