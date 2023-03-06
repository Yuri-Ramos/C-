using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        // quando é obrigatorio um requisito  na classe mae tem que ajustar nas classes filhas
        public Professor(string name) : base(name) 
        {
            
        }
        public decimal Salario { get; set; }


        public override void Apresentar() // assim como no java, no C# a anotaçao @override tbm existe 
        {
            Console.WriteLine($"Hello, I'm teather, My name is {Nome}, have age {Idade} old end my wage is {Salario:c} ");
        }
    }

}