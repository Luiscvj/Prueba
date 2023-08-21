using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("empleado");
        builder.HasKey(e => e.ID_Empleado);
          builder.Property(c => c.Nombre)
        .HasMaxLength(100);
        builder.Property(c => c.Apellido)
        .HasMaxLength(100);
        builder.Property(c => c.Cargo)
        .HasMaxLength(50);
        builder.Property(c => c.DNI)
        .HasMaxLength(20);
        builder.Property(c => c.Direccion)
        .HasMaxLength(255);
        builder.Property(c => c.Telefono)
        .HasMaxLength(20);

    }
}