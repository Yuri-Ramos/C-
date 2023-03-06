using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Hello, my name's {Nome}. My age is {Idade}.");

            
        }
    }
}