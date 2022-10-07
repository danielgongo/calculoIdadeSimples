using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MINI PROGRAMA CALCULAR IDADE");

            Pessoa people = new Pessoa();

            Console.Write("Nome da Pessoa: ");
            people.Nome = Console.ReadLine();

            Console.Write("Ano de nascimento: ");
            people.AnoNascimento = int.Parse(Console.ReadLine());

            people.ExibirDados();

            Console.ReadKey();
        }
    }
}
