using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SucursalAutomovilConfiguration : IEntityTypeConfiguration<Sucursal_Automovil>
{
    public void Configure(EntityTypeBuilder<Sucursal_Automovil> builder)
    {
        builder.ToTable("sucursal_automovil");

        builder.HasOne(x => x.Sucursal)
        .WithMany(x => x.Sucursal_Automoviles)
        .HasForeignKey(x => x.ID_Sucursal);

        builder.HasOne(x => x.Automovil)
        .WithMany(x => x.Sucursal_Automoviles)
        .HasForeignKey(x => x.ID_Automovil);
        
    }
}