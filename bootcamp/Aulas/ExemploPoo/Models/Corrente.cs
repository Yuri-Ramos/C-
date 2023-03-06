using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
           if(valor <=0)
           {
                Console.WriteLine($"Valor inferior a 0 favor refazer a ação ");
            }
            else
            {
                
                saldo += valor;
                Console.WriteLine($"Deposito de {valor:c} realizado com sucesso, valor restante de saldo {saldo:c}.");
                
            }
        }
    }
}