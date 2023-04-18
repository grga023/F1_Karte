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
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GRGA\\SQLEXPRESS;Initial Catalog=F1KarteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}
