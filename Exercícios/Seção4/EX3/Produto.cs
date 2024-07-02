using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3 {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int add) {
            Quantidade += add;
        }
        public void RemoverProdutos(int rem) {
            Quantidade -= rem;
        }
        public override string ToString() { // sobreposição
            return $"{Nome}, $ " +
                $"{Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, " +
                $"Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
