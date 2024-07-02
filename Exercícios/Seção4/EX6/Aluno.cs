using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6 {
    internal class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void Notas() {
            Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public override string ToString() {
            if (NotaFinal() >= 60.0) {
                return "APROVADO";
            }
            else {
                return $"REPROVADO\nFALTARAM {(60.0 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
