using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;


public class AutomovilConfiguration : IEntityTypeConfiguration<Automovil>
{
    public void Configure(EntityTypeBuilder<Automovil> builder)
    {
        builder.ToTable("automovil");
        builder.HasKey(x => x.ID_Automovil);

        builder.Property(x => x.Marca)
        .HasMaxLength(100);
        builder.Property(x => x.Modelo)
        .HasMaxLength(100);
        builder.Property(x => x.Tipo)
        .HasMaxLength(50);
        builder.Property(x => x.Precio_Diario)
        .HasPrecision(10,2);
    }
}