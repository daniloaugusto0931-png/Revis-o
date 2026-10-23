using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Revisão
{
    public class Prova
    {
        public int Id { get; set; }
        public string Disciplina { get; set; }
        public int Nota { get; set; }

        public List<string> Questoes { get; set; } = new List<string>();
        public List<char> Gabarito { get; set; } = new List<char>();

        public static List<Prova> Provas { get; set; } = new List<Prova>();

        public void ExibirDados()
        {
            Console.WriteLine($"Prova: {Id}");
            Console.WriteLine($"Disciplina: {Disciplina}");
            Console.WriteLine($"Nota: {Nota}");

            Console.WriteLine("Questões:");
            foreach (string item in Questoes)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine("Gabarito:");
            int contador = 0;

            foreach (char g in Gabarito)
            {
                contador++;
                Console.WriteLine($"{contador} - {g}");
            }
        }

        public static void Adicionar(int id, string disciplina, int nota)
        {
            Prova p = new Prova();

            p.Id = id;
            p.Disciplina = disciplina;
            p.Nota = nota;

            Provas.Add(p);

            Console.WriteLine("Prova adicionada com sucesso!");
        }

        public static void Editar(int id, string novaDisciplina, int novaNota)
        {
            Prova p = Provas.Find(prova => prova.Id == id);

            if (p != null)
            {
                p.Disciplina = novaDisciplina;
                p.Nota = novaNota;

                Console.WriteLine("Prova editada com sucesso!");
                p.ExibirDados();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar a prova.");
            }
        }

        public static void Remover(int id)
        {
            Prova p = Provas.Find(prova => prova.Id == id);

            if (p != null)
            {
                Provas.Remove(p);
                Console.WriteLine("Prova removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar a prova.");
            }
        }

        public static void Listar()
        {
            foreach (Prova p in Provas)
            {
                p.ExibirDados();
                Console.WriteLine("--------------------");
            }
        }
    }
}