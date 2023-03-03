using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadedeLinhas) LerArquivo(string caminho)
        {   
            try{

            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count());

            }catch (Exception ex)
            {
                Console.WriteLine("Excecao tratada"+ex.Message);
                return (false, new string[0], 0);
                
            }
        }
    }
}