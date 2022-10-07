using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade_poo
{
    public class Pessoa
    {
        private int anoNascimento;
        private string nome;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }

            set
            {
                this.anoNascimento = value;
            }
        }

        public string Nome
        {
            get { return this.nome; }
            set
            {
                this.nome = value.ToUpper(); //ToUpper para deixar as letras maiusculas
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de mascimento: " + this.AnoNascimento);
            Console.WriteLine("Idade: " + this.CalcularIdade() + " anos");
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano =  data.Year;

            int idade = ano - AnoNascimento;

            return idade;
        }
    }
}
