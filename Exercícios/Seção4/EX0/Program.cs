using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EX0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro novo = new Carro();

            Console.WriteLine("Digite um novo Carro:");
            Console.Write("Marca: ");
            novo.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            novo.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            novo.Ano = int.Parse(Console.ReadLine());
            novo.Disponivel = true; //Por padrão

            //novo.Alugar();
            //novo.Devolver();

            novo.MostrarInformacoes();



        }
    }
}
