using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;


public class Sucursal_AutomovilConfiguration : IEntityTypeConfiguration<Sucursal_Automovil>
{
    public void Configure(EntityTypeBuilder<Sucursal_Automovil> builder)
    {
       builder.ToTable("sucursal_automovil");

       builder.HasOne(x => x.Automovil)
       .WithMany(x => x.Sucursal_Automoviles)
       .HasForeignKey(x => x.ID_Automovil);

       builder.HasOne(x => x.Sucursal)
       .WithMany(x => x.Sucursal_Automoviles)
       .HasForeignKey(x => x.ID_Sucursal);

    }
}