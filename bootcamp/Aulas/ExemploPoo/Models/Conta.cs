using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public abstract class Conta // serve apenas como modelo para ser herdada e bnao pode ser instanciada 
    {
        protected decimal saldo;// protegico contra classes externas mais suas classes filhas podem alterar

        public abstract void Creditar(decimal valor);// não tem corpo pôs funciona apenas como gabarito

        public void ExibirSaldo()
        {
            Console.WriteLine($"Exibir Saldo {saldo:c}");
        }
    }
}