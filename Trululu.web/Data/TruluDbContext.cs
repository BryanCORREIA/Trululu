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
        public DbSet<User> utilisateurs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Trululu;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<Casting>().ToTable("casting");
            modelBuilder.Entity<Civility>().ToTable("civility");
            modelBuilder.Entity<Company>().ToTable("compagny");
        }
    }
}

