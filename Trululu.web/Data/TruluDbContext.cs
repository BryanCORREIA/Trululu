using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trululu.web.Entities;

namespace Trululu.web.Data
{
    public class TruluDbContext : DbContext
    {
        public DbSet<Utilisateur> utilisateurs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Trululu;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur>().ToTable("utilisateurs");
            modelBuilder.Entity<Casting>().ToTable("castings");
            modelBuilder.Entity<Civilite>().ToTable("civilite");
            modelBuilder.Entity<Entreprise>().ToTable("entreprises");
        }
    }
}

