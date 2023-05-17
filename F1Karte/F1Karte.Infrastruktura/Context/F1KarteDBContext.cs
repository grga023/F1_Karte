using F1Karte.Domen.Modeli;
using Microsoft.EntityFrameworkCore;

namespace F1Karte.Infrastruktura.Context
{
    public class F1KarteDBContext : DbContext
    {
        public F1KarteDBContext()
        {

        }
        public F1KarteDBContext(DbContextOptions<F1KarteDBContext> options) : base(options)
        {
        }
        public DbSet<Karta> Karte => Set<Karta>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Data Source=PC-GRGA\\SQLEXPRESS;Initial Catalog=F1Karte1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}

//Uutstvo:
//Potrebno je izmeniti knekcioni string. U delu source upisati naziv servera.
//u PackageMenagerConsole koristiti sledece komannde
//1.EntityFrameworkCore\Add-Migration
//2.EntityFrameworkCore\Update-Database