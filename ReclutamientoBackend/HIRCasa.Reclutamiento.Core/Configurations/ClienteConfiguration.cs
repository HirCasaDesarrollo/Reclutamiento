using HIRCasa.Reclutamiento.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIRCasa.Reclutamiento.Core.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(e => e.Id).HasColumnName("Id").ValueGeneratedOnAdd();

        builder.Property(t => t.Nombre)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(t => t.Correo)
            .HasMaxLength(100)
            .IsRequired();
    }
}
