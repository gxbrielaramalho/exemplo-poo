using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Models
{
    public class Professor : Pessoa 
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um professor que ganha {Salario} reais por mês.");
        }
    }
}