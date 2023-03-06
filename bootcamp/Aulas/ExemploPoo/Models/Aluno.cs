using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
        // quando é obrigatorio um requisito  na classe mae tem que ajustar nas classes filhas
    {
        public Aluno()
        {
            
        }
        public Aluno(string name) : base(name)
        {
            
        }
        public double Nota { get; set; }
    }
}