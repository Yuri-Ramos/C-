using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    //nome de classe é sempre PascalCase

    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa
    {   
        // nome de propriedade PascalCase
        public string? Nome { get; set; }
        public int Idade { get; set; }
        //evitar abreviações e sem caracter especial, apenas o __
        public string? NomeRepresentanteLegalDaPessoaFisica{get;set;}
        

        //nome de metodo é sempre PascalCase

        /// <summary>
        /// Faz a pessoa se apresentar com nome e idade
        /// </summary>
                public void Apresentar()
        {
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
            Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos.");
        }


    }
}