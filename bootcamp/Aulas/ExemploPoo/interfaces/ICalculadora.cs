using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.interfaces
{
    public interface ICalculadora
    {
        int somar(int num1, int num2);
        int dividir (int num1, int num2);

        int subtrair(int num1, int num2);

        int Multiplicar (int num1, int num2);

    }
}