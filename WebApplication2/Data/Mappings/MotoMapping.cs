using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ChallengeC_.Models;

namespace ChallengeC_.Data.Mappings
{
    public class MotoMapping : IEntityTypeConfiguration<Moto>
    {
        public void Configure(EntityTypeBuilder<Moto> builder)
        {
            builder.ToTable("MTT_MOTO");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(m => m.Marca)
                .HasColumnName("MARCA")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Modelo)
                .HasColumnName("MODELO")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(m => m.Placa)
                .HasColumnName("PLACA")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(m => m.Estado)
                .HasColumnName("ESTADO")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m => m.Local)
                .HasColumnName("LOCAL")
                .HasMaxLength(100);
        }
    }
}
