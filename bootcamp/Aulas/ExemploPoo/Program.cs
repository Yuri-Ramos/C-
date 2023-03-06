using ExemploPoo.Models;
using ExemploPoo.interfaces;




















// //desafio 3 Poo

// using System;

// //TODO: Complete os espaços em branco com uma possível solução para o problema.
// class Desafio {
//     static void Main() {
//         int N = int.Parse(Console.ReadLine());

//         for (int i = 0; i < N; i++) {
//             string[] valores = Console.ReadLine().Split(' ');
//             int X = int.Parse(valores[0]);
//             int Y = int.Parse(valores[1]);

//             if (Y == 0) {
//                 Console.WriteLine("divisao impossivel");
//             } else {
//                 double divisao = (double) X / Y;
//                 Console.WriteLine(divisao.ToString("F1"));
                
//             }
//         }
//     }
// }













// // desafio POo 2
// using System;

// namespace Start
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double a, b, c, media;

//             // ler as três notas
//             a = double.Parse(Console.ReadLine());
//             b = double.Parse(Console.ReadLine());
//             c = double.Parse(Console.ReadLine());

//             // calcular a média ponderada
//             media = (a * 2 + b * 3 + c * 5) / 10;

//             // exibir a média com uma casa decimal
//             Console.WriteLine("MEDIA = " + media.ToString("F1"));

//             Console.ReadLine();

//         }
//     }
// }










// //desafio Poo 1

//         // cria um array para armazenar os valores
//         int[] valores = new int[100];

//         // lê os valores e armazena no array
//         for (int i = 0; i < 100; i++) {
//             valores[i] = int.Parse(Console.ReadLine());
//         }

//         // encontra o maior valor e sua posição
//         int maxValor = valores[0];
//         int maxPosicao = 0;

//         for (int i = 1; i < 100; i++) {
//             if (valores[i] > maxValor) {
//                 maxValor = valores[i];
//                 maxPosicao = i;
//             }
//         }

//         // exibe o resultado
//         Console.WriteLine(maxValor);
//         Console.WriteLine(maxPosicao+1);





















// ICalculadora calc = new Calculadora();

// Console.WriteLine(calc.Multiplicar(12, 5));









// Computador c =new Computador();

// Console.WriteLine(c.ToString());

// Pessoa p1 = new Pessoa("alemao");
// Professor  pl1= new Professor("alemaoaa");
// Aluno a2 = new Aluno("al");









// ContaCorrente c1 = new ContaCorrente(0010,569M);

// c1.Sacar(500);
// c1.ExibirSaldo();
// c1.Depositar(250);
// c1.ExibirSaldo();

// Aluno a1 = new Aluno();
// a1.Nome = "Al";
// a1.Idade = 56;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Aurelio";
// p1.Idade = 15;
// p1.Salario = 15647M;
// p1.Apresentar();


// Corrente c2 = new Corrente();
// c2.Creditar(500);
// c2.ExibirSaldo();
// c2.Creditar(500);
// c2.ExibirSaldo();










// Pessoa p1 = new Pessoa();
// p1.Nome = "Zezin";
// p1.Idade = 25;
// p1.Apresentar();


//Encapsulamento serva para definir e proteger uma classe e definir limites para alteração de suas propriedade
// serve para ocultar seu comportamento e expor apenas a ação

