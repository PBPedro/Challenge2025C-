using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ChallengeC_.Models;

namespace ChallengeC_.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("MT_USUARIO");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasColumnName("SENHA")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
