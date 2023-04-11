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
    
//     public class F1CardContext : DbContext
//     {
//             public F1CardContext(DbContextOptions<F1CardContext> options) : base(options)
//             {
//             }
    
//         public DbSet<F1Card> F1Cards { get; set; }
//         public DbSet<City> Cities { get; set; }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             // Configure PTT as foreign key for F1Card
//             modelBuilder.Entity<F1Card>()
//                 .HasOne(c => c.City)
//                 .WithMany(p => p.F1Cards)
//                 .HasForeignKey(c => c.PTT)
//                 .OnDelete(DeleteBehavior.Cascade);
//         }
//             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//             {
//                 if (!optionsBuilder.IsConfigured)
//                 {
//                     optionsBuilder.UseSqlServer("Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;");
//                 }
//             }
//     }
}
