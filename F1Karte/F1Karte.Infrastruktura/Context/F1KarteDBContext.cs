using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F1Karte.Domain.Modeli;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Context
{
    public class F1KarteDBContext : DbContext
    {
        public F1KarteDBContext(DbContextOptions<F1KarteDBContext> options) : base(options)
        {
        }
        public DbSet<Karta> Karte { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Karta>();
        }

    }
}
