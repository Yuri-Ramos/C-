using ExemploExplorando.models;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

p1.Nome = "Yuri";
p1.Idade = 22;
p2.Nome = "Joaquina";
p2.Idade = 2;
p1.Sobrenome="ferreira";
p2.Sobrenome="Pagodeiro";

p1.Apresentar();
p2.Apresentar();