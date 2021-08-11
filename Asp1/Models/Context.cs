using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp1.Models
{
    public class Context : DbContext
       
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            optionsBuilder.UseSqlServer(@"Server=(localbd)\mssqllocalbd;Database=Cursomvc;Integrated Security=True");
         }
    }

}