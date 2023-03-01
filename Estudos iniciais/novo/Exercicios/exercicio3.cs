using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_iniciais.novo.Exercicios
{
    public class exercicio3
    {
         Console.Write("Digite a idade do usuário: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o sexo do usuário (homem/mulher): ");
        string sexo = Console.ReadLine();

        Console.Write("Digite a condição especial do usuário (deficiente/grávida/nenhuma): ");
        string condicao = Console.ReadLine();

        if (idade > 60 || sexo == "mulher" && condicao == "grávida" || condicao == "deficiente") {
            Console.WriteLine("Fila preferencial");
        } else {
            Console.WriteLine("Fila comum");
    }
}