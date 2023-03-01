// See https://aka.ms/new-console-template for more information
using System;


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 15;
arrayInteiros[1] = 65;
arrayInteiros[2] = 85;  

//length= capacidade do array
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");

}