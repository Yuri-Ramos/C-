using ExemploPoo.Models;

ContaCorrente c1 = new ContaCorrente(0010,569M);

c1.Sacar(500);
c1.ExibirSaldo();
c1.Depositar(250);
c1.ExibirSaldo();

Aluno a1 = new Aluno();
a1.Nome = "Al";
a1.Idade = 56;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Aurelio";
p1.Idade = 15;
p1.Salario = 15647M;
p1.Apresentar();










// Pessoa p1 = new Pessoa();
// p1.Nome = "Zezin";
// p1.Idade = 25;
// p1.Apresentar();


//Encapsulamento serva para definir e proteger uma classe e definir limites para alteração de suas propriedade
// serve para ocultar seu comportamento e expor apenas a ação

