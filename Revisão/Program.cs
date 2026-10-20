using Revisão;

Danilo escola1 = new Danilo();
escola1.Nome = "Danilo";
escola1.Idade = 17;
escola1.Escola = "Augustos";
escola1.Alunos = new List<string> { "João", "Maria", "Pedro" };
escola1.Professores = new List<string> { "Carlos", "Ana", "Lucas" };
escola1.ExibirDados();

Danilo escola2 = new Danilo();
escola2.Escola = "Zoroastro";
escola2.Alunos = new List<string> { "Gabriel", "Julia", "Arthur" };
escola2.ExibirDados();