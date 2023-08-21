using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente> 
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");

        builder.HasKey(t => t.ID_Cliente);
        builder.Property(c => c.Nombre)
        .HasMaxLength(100);
        builder.Property(c => c.Apellido)
        .HasMaxLength(100);
        builder.Property(c => c.Email)
        .HasMaxLength(100);
        builder.Property(c => c.DNI)
        .HasMaxLength(20);
        builder.Property(c => c.Direccion)
        .HasMaxLength(255);
        builder.Property(c => c.Telefono)
        .HasMaxLength(20);

    
    }
}