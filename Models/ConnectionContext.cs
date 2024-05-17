
using Microsoft.EntityFrameworkCore;

namespace back_end_D_Milhas.Models
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Companhia> Companhias { get; set; }
        public DbSet<Depoimento> Depoimentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=dMilhas;" +
                "User Id=postgres;" +
                "Password=081501;"
            );
        
    }
}