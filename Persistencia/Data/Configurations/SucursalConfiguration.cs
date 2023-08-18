
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
        builder.ToTable("sucursal");
        builder.HasKey(x => x.ID_Sucursal);
        builder.Property(x => x.Nombre)
        .HasMaxLength(100);
        builder.Property(x => x.Direccion)
        .HasMaxLength(255);
        
        builder.Property(x => x.Telefono)
        .HasMaxLength(20);
        



        builder.HasMany(x =>x.Automoviles)
        .WithMany(a => a.Sucursales)
        .UsingEntity<Sucursal_Automovil>();
    }
}