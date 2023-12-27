using DbWithEntityFramework.Data.Mapping;
using DbWithEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbWithEntityFramework.Data
{
    public class IdentificacaoDataContext : DbContext
    {
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localHost,1433;Database=Identify;User Id=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MoradorMap());
            modelBuilder.ApplyConfiguration(new VisitanteMap());
        }

    }
}
