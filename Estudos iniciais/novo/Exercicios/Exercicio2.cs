using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.obj
{
    public class Exercicio2
    {
        int a, b, c;
        
Console.WriteLine("Digite três valores inteiros diferentes:");
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

// Verifica qual é o maior valor e o coloca na primeira variável
if (a < b)
{
    int temp = a;
    a = b;
    b = temp;
}
if (a < c)
{
    int temp = a;
    a = c;
    c = temp;
}

// Verifica qual é o segundo maior valor e o coloca na segunda variável
if (b < c){
    int temp = b;
    b = c;
    c = temp;
}

// Imprime os valores em ordem decrescente
Console.WriteLine($"{a}, {b}, {c}");
    }
}