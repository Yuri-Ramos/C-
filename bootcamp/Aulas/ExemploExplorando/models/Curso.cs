using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        /// <summary>
        /// Metodo para Adicionar alunos
        /// </summary>
        /// <param name="aluno">Nome do aluno </param>
        public void Adicionar(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        /// <summary>
        /// Metodo para remover alunos da lista
        /// </summary>
        /// <param name="aluno">Nome do Aluno</param>
        public bool Remover(Pessoa aluno)
        {
            
            return Alunos.Remove(aluno);
        }
        public int AlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso: {Nome}");

            for (int count=0; count < Alunos.Count; count++)
            {
                
                string texto = "  N° " + (count+1)+"  " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
                // Console.WriteLine($"Aluno n°: {Alunos[count].NomeCompleto}"+texto);
            }

            // int contador = 0;
            // foreach (Pessoa aluno in Alunos)
            // {
            //     contador++;
            //     Console.WriteLine($"Aluno n°{contador}: {aluno.NomeCompleto}");
            // }
        }
    }
}