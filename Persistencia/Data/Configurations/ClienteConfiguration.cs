using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");
 builder.HasKey(x => x.ID_Cliente);
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
        builder.Property(x => x.Email)
        .HasMaxLength(100);
    }
}