///exercicios

// escolha o exercicio que quer ver 
using System;


    static void Main(string[] args) {
Console.WriteLine("Digite o numero do exercicio que quer testar:\n" +
    " 1 algoritmo que leia a entrada de um número inteiro fornecido pelo usuário,\n " +
    " 2 Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.\n," +
    " 3 Implemente um programa tomador de decisão que considera as seguintes opções para\r\ndeterminar se o usuário usará a fila preferencial ou a fila comum. \n" +
    "4 O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar\r\numa indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (\r\naltura )2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição\r\nde acordo com a tabela abaixo. ;\n" +
    "5 Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma\r\nmaneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela\r\né palíndroma ou não.\n" +
    "6 Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule atabuada\r\nde N. Mostre a tabuada na forma:\r\nN x 1 = X \n" +
    "7 Desenvolver uma calculadora simples que realiza os cálculos de Soma, Subtração,\r\nMultiplicação e Divisão\n" +
    "8 Desenvolver um algoritmo que gere nomes completos aleatórios. O usuário deve ser capaz\r\nde escolher se quer gerar um nome masculino ou feminino.\n" + 
    "0 para sair");

int opcao = int.Parse(Console.ReadLine());

Console.Clear();
switch (opcao)
{
    case 1:
        

       break;
    case 2:

        
        break;
    case 3:
      

        
        break;
    case 4:
        Console.WriteLine("Você escolheu dividir.");
        // realiza a operação de divisão aqui


        break;
    case 5:
        Console.WriteLine("Você escolheu dividir.");
        // realiza a operação de divisão aqui


        break;
    case 6:
        Console.WriteLine("Você escolheu dividir.");
        // realiza a operação de divisão aqui


        break;
   

    case 8:
        Console.WriteLine("Você escolheu dividir.");
        // realiza a operação de divisão aqui


        break;
       
    default:
        Console.WriteLine("Opção inválida.");


        break;
}
    }