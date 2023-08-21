using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;
namespace Persistencia.Data.Configuration;

public class Registro_DevolucionC : IEntityTypeConfiguration<Registro_Devolucion>
{
    public void Configure(EntityTypeBuilder<Registro_Devolucion> builder)
    {
        builder.ToTable("registro_devolucion");
        builder.HasKey(x => x.ID_Registro);

        builder.Property(x => x.Fecha_Devolucion)
        .HasColumnType("date");
        builder.Property(x => x.Combustible_Devuelto)
        .HasPrecision(5,2);
        builder.Property(x => x.Monto_Adicional)
        .HasPrecision(10,2);

        builder.HasOne(x => x.Alquiler)
        .WithMany(x=> x.Registro_Devoluciones)
        .HasForeignKey(x=>x.ID_Alquiler);

        builder.HasOne(x => x.Empleado)
        .WithMany(x=> x.Registro_Devoluciones)
        .HasForeignKey(x=>x.ID_Empleado);



    }
}