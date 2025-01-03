using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;
        public bool Disponivel;

        public void MostrarInformacoes()
        {
            Console.WriteLine("Aqui está as informações do Veículo: ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"MARCA..........................{Marca}");
            Console.WriteLine($"MODELO.........................{Modelo}");
            Console.WriteLine($"ANO............................{Ano}");
            if (Disponivel)
            {
                Console.WriteLine($"CONDIÇÃO.......................DISPONÍVEL");
            }
            else
            {
                Console.WriteLine($"CONDIÇÃO.......................ALUGADO");
            }
            Console.WriteLine("-------------------------------------");
        }
        public void Alugar()
        {
            Disponivel = false;
        }
        public void Devolver() 
        {
            Disponivel = true;
        }
    }
}
