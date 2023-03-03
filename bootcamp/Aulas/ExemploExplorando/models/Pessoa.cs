using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    
    
    public class Pessoa
    {
        public Pessoa()
        { 

        }
        public Pessoa(string nome, string sobrenome)
        {
                this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public void Desconstruct( out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome; // não aceita valores nulos
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {


                if (value == "")
                {
                    throw new ArgumentException("o nome nao pode ser vazio");
                }
                _nome = value;
            }


        }
        // get e setter são para propriedades
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();	
    

    private int _idade; 
        public int Idade { get=> _idade;

            set {
            if (value<0)
            {
                throw new ArgumentException("idade nao pode ser Menor que zero.");
            }
            _idade = value;
        }}

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, {NomeCompleto}");
        }


    }
}