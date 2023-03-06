using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPoo.interfaces;

namespace ExemploPoo.Models
{
    public class Calculadora : ICalculadora

    {
        public int dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}