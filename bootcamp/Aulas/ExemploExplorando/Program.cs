using ExemploExplorando.models;


Pessoa p1 = new Pessoa();
p1.Nome = "Yuri";
p1.Idade = 22;
p1.Sobrenome="ferreira";


Pessoa p2 = new Pessoa();

p2.Nome = "Joaquina";
p2.Idade = 2;
p2.Sobrenome="Pagodeiro";

Pessoa p3 = new Pessoa(nome:"Joaozin", sobrenome:"das cove");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Curso deIngles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.Adicionar(p1);
cursoDeIngles.Adicionar(p3);
cursoDeIngles.ListarAlunos();
cursoDeIngles.Remover(p1);
cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa();

// p1.Nome = "Yuri";
// p1.Idade = 22;
// p2.Nome = "Joaquina";
// p2.Idade = 2;
// p1.Sobrenome="ferreira";
// p2.Sobrenome="Pagodeiro";

// p1.Apresentar();
// p2.Apresentar();