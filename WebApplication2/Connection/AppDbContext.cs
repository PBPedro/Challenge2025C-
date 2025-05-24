using Microsoft.EntityFrameworkCore;
using ChallengeC_.Models;
using ChallengeC_.Data.Mappings;

namespace ChallengeC_.Connection
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // 🔗 DbSets (Tabelas do banco)
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Moto> Motos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🏍️ Mapeamento de Moto
            modelBuilder.ApplyConfiguration(new MotoMapping());

            // 👤 Mapeamento de Usuario
            modelBuilder.ApplyConfiguration(new UsuarioMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
