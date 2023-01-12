using Conhecendo.Models;

string apresentacao = "olá seja bem vindo";
int quantidade = 1;
double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;


Console.WriteLine($"{apresentacao},{quantidade},{altura.ToString("0-00")},{preco},{condicao}");

// instancia de objeto com canelcase
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome ="Yuri";
pessoa1.Idade = 18;

pessoa1.Apresentar();
