using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AlquilerConfiguration : IEntityTypeConfiguration<Alquiler>
{
    public void Configure(EntityTypeBuilder<Alquiler> builder)
    {
        builder.ToTable("alquiler");
        builder.HasKey(x => x.ID_Alquiler);
        builder.Property(x => x.Fecha_Inicio)
        .HasColumnType("date");
        builder.Property(x => x.Fecha_Fin)
        .HasColumnType("date");

        builder.Property(x =>x.Costo_Total)
        .HasPrecision(10,2);

          builder.Property(x => x.Estado)
        .HasMaxLength(50);

        builder.HasOne(x => x.Cliente)
        .WithMany(x => x.Alquileres)
        .HasForeignKey(x => x.ID_Cliente); 

        builder.HasOne(x => x.Automovil)
        .WithMany(x => x.Alquileres)
        .HasForeignKey(x => x.ID_Automovil);   
    }
}