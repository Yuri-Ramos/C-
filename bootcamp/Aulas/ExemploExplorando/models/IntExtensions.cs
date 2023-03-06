using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public static class IntExtensions
    {
        public static bool Ehpar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}