using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz {
    internal class Program {
        static void Main(string[] args) {
            int m, n, x, k, l;

            Console.Write("Digite o número de linhas da matriz: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas da matriz: ");
            n = int.Parse(Console.ReadLine());

            // Preenchendo a matriz
            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            Console.Write("Digite um número que pertença a matriz: ");
            x = int.Parse(Console.ReadLine());
            // Laço-Duplo 1 para verificar as posições correspondentes ao valor escolhido
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine($"Posição({i},{j})");
                        if (j > 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j < n - 1) {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < m - 1) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
