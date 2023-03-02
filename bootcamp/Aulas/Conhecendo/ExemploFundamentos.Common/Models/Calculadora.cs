using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
      /// <summary>
      /// Realiza a soma de dois numeros
      /// </summary>
      /// <param name="x">Um numero intero</param>
      /// <param name="y">Segundo numero para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        //  public void Subtrair(int x, int y)
        // {
        //     Console.WriteLine($"{x} - {y} = {x-y}");
        // }
        //  public void Dividir(int x, int y)
        // {
        //     Console.WriteLine($"{x}  /{y} = {x/y}");
        // }
        //  public void Multiplicar(int x, int y)
        // {
        //     Console.WriteLine($"{x} X {y} = {x*y}");
        // }
        // public void Potencia(int x, int y)
        // {
        //     double pot=Math.Pow(x, y);
        //     Console.WriteLine($"{x} ^{y} = {pot}");
        // }
      public void Raiz(double x)
      {
        double raiz= Math.Sqrt(x);
        Console.WriteLine($"{x} = {raiz}");
      }
    }
}