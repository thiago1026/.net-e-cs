using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"olá meu nome é {Nome} e sou um aluno nota {Nota}");
        }

    }
}