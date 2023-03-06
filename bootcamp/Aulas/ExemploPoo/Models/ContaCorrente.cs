using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {

        public ContaCorrente (int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;

        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso, valor restante de saldo {saldo:c}.");
            }
            else
            {
                Console.WriteLine($"Saque de {valor:c} não foi possivel, sem saldo");
            }
        }

         public void Depositar(decimal valor)
        {
            if (valor <=0)
            {
                Console.WriteLine($"Deposito de {valor:c} não foi possivel, svalor nao pode ser menor que zero");
                  }
            else
            {
                saldo += valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso, valor restante de saldo {saldo:c}.");
                
            }
        }
        public void ExibirSaldo()
            {
                Console.WriteLine($"Saldo da conta 000-{NumeroConta}  de {saldo:c}");
                
            }
        }

    }
