using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODULOAPI.Entities
{
    public class Contato
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        
        public string Telefone { get; set; }  

        public bool Ativo { get; set; }  


    }
}