using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() { 
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            porcentagem = porcentagem / 100;
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem);
        }
        public override string ToString() {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
