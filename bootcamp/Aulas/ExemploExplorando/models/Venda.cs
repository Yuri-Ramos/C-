using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Venda
    {
        public int Id { get; set; }

        //[JsonProperty("Nome_Produto")] serve para mudar o atributo e adicionar uma meta data
        public string Produto { get; set; } 
        public decimal Preco { get; set; }  
        public DateTime Data { get; set; }

        public decimal? Desconto { get; set; }
    }
}