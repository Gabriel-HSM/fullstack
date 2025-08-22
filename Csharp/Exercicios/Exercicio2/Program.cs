using Exercicio2.models;

Pessoa p1 = new Pessoa(nome: "Gabriel", sobrenome: "Xavier");

Pessoa p2 = new Pessoa("Eduardo","Neves");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








// p1.Nome = "Gabriel";
// p1.Sobrenome = "Xavier";
// p1.Idade = 20;
// p1.Apresentar();