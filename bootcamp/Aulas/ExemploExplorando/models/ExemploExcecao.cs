using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }

         public void Metodo2(){
            Metodo3();
        }
         public void Metodo3(){
            try{
            Metodo4();

            }catch (Exception ex)
            {
                Console.WriteLine("Excecao tratada"+ex.Message);
            }
        }
         public void Metodo4(){
            throw new Exception("Ocorreu uma exception");
        }
    }
}