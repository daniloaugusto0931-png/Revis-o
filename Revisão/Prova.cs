using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Prova
    {
        public int Id { get; set; }
        public string Disciplina { get; set; }
        public int Nota { get; set; }
        public List<string> Questoes { get; set; } = new List<string>();
        public void ExibirDados()
        {
            Console.WriteLine($"Prova: {Id}");
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine($"Nota: {Nota}");
            Console.WriteLine($"Questão: {Questoes}");
            foreach (string item in Questoes)
            {
                Console.WriteLine($"- {item}");

            }

        }
    }
}
