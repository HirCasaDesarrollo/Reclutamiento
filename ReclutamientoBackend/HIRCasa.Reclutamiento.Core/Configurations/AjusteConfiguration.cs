
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using HIRCasa.Reclutamiento.Entities.Model;
using HIRCasa.Reclutamiento.Entities;

namespace HIRCasa.Reclutamiento.Core.Configurations;

public class AjusteConfiguration : IEntityTypeConfiguration<Ajuste>
{
    public void Configure(EntityTypeBuilder<Ajuste> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(e => e.Id).HasColumnName("Id").ValueGeneratedOnAdd();
    }
}
