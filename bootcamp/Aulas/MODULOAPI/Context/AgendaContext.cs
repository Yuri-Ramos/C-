using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MODULOAPI.Entities;

namespace MODULOAPI.Context
{
    public class AgendaContext : DbContext// herdando essa classe tem as operaçoes que vamos usar
    {
    
            public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

            }
            public DbSet<Contato> Contatos{ get; set; }

        }
    }
