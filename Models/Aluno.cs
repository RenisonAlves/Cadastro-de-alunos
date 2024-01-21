using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrarAlunos.Models
{
    public class Aluno
    {
        protected string Nome{ get; set; }
        protected int Idade{get; set;}        
        public string Endereco { get; set; }

        public Aluno(string nome, int idade, string endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }

    }
}