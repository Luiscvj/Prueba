using System.util.zlib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;


public class Registro_EntregaConfiguration : IEntityTypeConfiguration<Registro_Entrega>
{
    public void Configure(EntityTypeBuilder<Registro_Entrega> builder)
    {
        builder.ToTable("registro_entrega");
        builder.HasKey(x => x.ID_Registro);

        builder.Property(x => x.Fecha_Entrega)
        .HasColumnType("date");

        builder.Property(x => x.Combustible_Entregado)
        .HasPrecision(5,2);

        builder.HasOne(x => x.Alquiler)
        .WithMany(x => x.Registro_Entregas)
        .HasForeignKey(x => x.ID_Alquiler);

        builder.HasOne(x => x.Empleado)
        .WithMany(x => x.Registro_Entregas)
        .HasForeignKey(x => x.ID_Empleado);
    }
}