using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("empleado");
         builder.HasKey(x => x.ID_Empleado);
        builder.Property(x => x.Nombre)
        .HasMaxLength(100);
        builder.Property(x => x.Apellido)
        .HasMaxLength(100);
        builder.Property(x => x.DNI)
        .HasMaxLength(20);
        builder.Property(x => x.Direccion)
        .HasMaxLength(255);
        builder.Property(x => x.Telefono)
        .HasMaxLength(20);
        builder.Property(x => x.Cargo)
        .HasMaxLength(50);

    }
}