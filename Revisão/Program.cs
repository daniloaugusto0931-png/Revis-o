using Revisão;
using Revisão;

using System;
using System.Collections.Generic;
using Revisão;

Danilo escola1 = new Danilo();

escola1.Nome = "Danilo";
escola1.Idade = 17;
escola1.Escola = "Augustos";
escola1.Alunos = new List<string> { "João", "Maria", "Pedro" };
escola1.Professores = new List<string> { "Carlos", "Ana", "Lucas" };

Prova provaMatematica = new Prova();
provaMatematica.Id = 1;
provaMatematica.Disciplina = "Matemática";
provaMatematica.Nota = 10;
provaMatematica.Questoes.Add("Quanto é 2+2?");
provaMatematica.Questoes.Add("Quanto é 5x5?");
provaMatematica.Questoes.Add("Quanto é 20-15?");
provaMatematica.Gabarito.Add('A');
provaMatematica.Gabarito.Add('C');
provaMatematica.Gabarito.Add('B');

Prova.Provas.Add(provaMatematica);

Prova provaPortugues = new Prova();
provaPortugues.Id = 2;
provaPortugues.Disciplina = "Português";
provaPortugues.Nota = 15;
Prova.Provas.Add(provaPortugues);

Prova provaGeografia = new Prova();
provaGeografia.Id = 3;
provaGeografia.Disciplina = "Geografia";
provaGeografia.Nota = 8;
Prova.Provas.Add(provaGeografia);

escola1.ExibirDados();

int escolha = 0;

while (escolha != 5)
{
  
    Console.WriteLine("\n1 - Ver provas");
    Console.WriteLine("2 - Adicionar prova");
    Console.WriteLine("3 - Editar prova");
    Console.WriteLine("4 - Remover prova");
    Console.Write("\nEscolha uma opção: ");

    int.TryParse(Console.ReadLine(), out escolha);

    if (escolha == 1)
    {
        Prova.Listar();
    }
    else if (escolha == 2)
    {
        Console.Write("Digite o ID da prova: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a disciplina: ");
        string disciplina = Console.ReadLine()!;

        Console.Write("Digite a nota: ");
        int nota = int.Parse(Console.ReadLine()!);

        Prova.Adicionar(id, disciplina, nota);
    }
    else if (escolha == 3)
    {
        Prova.Listar();

        Console.Write("\nDigite o ID da prova que deseja editar: ");
        int id = int.Parse(Console.ReadLine()!);

        Prova prova = Prova.Provas.Find(p => p.Id == id);

        if (prova != null)
        {
            Console.WriteLine("\nO que deseja editar?");
            Console.WriteLine("1 - Disciplina");
            Console.WriteLine("2 - Nota");
            Console.WriteLine("3 - Questões");
            Console.WriteLine("4 - Gabarito");
            Console.Write("Escolha: ");

            int opcaoEditar = int.Parse(Console.ReadLine()!);

            if (opcaoEditar == 1)
            {
                Console.Write("Digite a nova disciplina: ");
                prova.Disciplina = Console.ReadLine()!;
                Console.WriteLine("Disciplina alterada!");
            }
            else if (opcaoEditar == 2)
            {
                Console.Write("Digite a nova nota: ");
                prova.Nota = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Nota alterada!");
            }
            else if (opcaoEditar == 3)
            {
                if (prova.Questoes.Count > 0)
                {
                    Console.WriteLine("\nQuestões atuais:");

                    for (int i = 0; i < prova.Questoes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {prova.Questoes[i]}");
                    }

                    Console.Write("Qual questão deseja editar? ");
                    int numero = int.Parse(Console.ReadLine()!);

                    if (numero >= 1 && numero <= prova.Questoes.Count)
                    {
                        Console.Write("Digite a nova questão: ");
                        prova.Questoes[numero - 1] = Console.ReadLine()!;
                        Console.WriteLine("Questão alterada!");
                    }
                    else
                    {
                        Console.WriteLine("Questão não encontrada.");
                    }
                }
                else
                {
                    Console.WriteLine("Essa prova ainda não tem questões.");
                }
            }
            else if (opcaoEditar == 4)
            {
                if (prova.Gabarito.Count > 0)
                {
                    Console.WriteLine("\nGabarito atual:");

                    for (int i = 0; i < prova.Gabarito.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {prova.Gabarito[i]}");
                    }

                    Console.Write("Qual resposta deseja editar? ");
                    int numero = int.Parse(Console.ReadLine()!);

                    if (numero >= 1 && numero <= prova.Gabarito.Count)
                    {
                        Console.Write("Digite a nova resposta: ");
                        string resposta = Console.ReadLine()!;

                        if (!string.IsNullOrWhiteSpace(resposta))
                        {
                            prova.Gabarito[numero - 1] =
                                char.ToUpper(resposta[0]);

                            Console.WriteLine("Gabarito alterado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Resposta não encontrada.");
                    }
                }
                else
                {
                    Console.WriteLine("Essa prova ainda não tem gabarito.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
        else
        {
            Console.WriteLine("Prova não encontrada.");
        }
    }
    else if (escolha == 4)
    {
        Prova.Listar();

        Console.Write("\nDigite o ID da prova que deseja remover: ");
        int id = int.Parse(Console.ReadLine()!);

        Prova.Remover(id);
    }
    else if (escolha == 5)
    {
        Console.WriteLine("Programa encerrado!");
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}


Brayan escola2 = new Brayan();
escola2.Nome = "Brayan";
escola2.Idade = 16;
escola2.Escola = "Augustos";
escola2.Amigos = new List<string> { "João", "Maria", "Pedro" };
escola2.Professores = new List<string> { "Carlos", "Ana", "Lucas" };
Danilo escola3 = new Danilo();
escola3.Escola = "Zoroastro";
escola3.Alunos = new List<string> { "Gabriel", "Julia", "Arthur" };
escola3.ExibirDados();