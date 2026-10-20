using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Danilo
    {
        public string Nome { get; set; }
        public string Escola { get; set; }
        public List  <string> Alunos { get; set; }
        public List<string> Professores { get; set; }
        public int Idade { get; set; }
        public void ExibirDados()
        {
            Console.WriteLine($"Minha escola é: {Escola}");
            Console.WriteLine($"Os alunos são");
            foreach (string aluno in Alunos)
            {
                Console.WriteLine($"- {aluno}");
            }
        }
    }

    
}
