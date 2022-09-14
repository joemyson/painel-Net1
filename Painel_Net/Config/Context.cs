using Microsoft.EntityFrameworkCore;
using Painel_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Painel_Net.Config
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>option):base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Painel> Painel { get; set; }
    }
}
