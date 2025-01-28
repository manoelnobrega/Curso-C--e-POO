using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas {
    internal class Funcionario {
        public int ID {
            get; set;
        }
        public string Nome {
            get; set;
        }
        public double Salario {
            get; private set;
        }

        public Funcionario(int id, string nome, double salario) {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem) {
            Salario += ((porcentagem / 100) * Salario);
        }

        public override string ToString() {
            return $"{ID}, {Nome}, R$ {Salario}";
        }

    }
}
