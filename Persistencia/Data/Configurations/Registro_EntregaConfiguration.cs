using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Registro_EntregaConfiguration : IEntityTypeConfiguration<Registro_Entrega>
{
    public void Configure(EntityTypeBuilder<Registro_Entrega> builder)
    {
        builder.ToTable("registro_Entrega");

        builder.HasKey(x => x.ID_Registro);
        
        builder.Property(x => x.Fecha_Entrega)
        .HasColumnType("date");
        builder.Property(x => x.Combustible_Entregado)
        .HasPrecision(5,2);
        builder.Property(x => x.Kilometraje_Entregado)
        .HasMaxLength(11);
       



        builder.HasOne(x => x.Empleado)
        .WithMany(x => x.Registro_Entregas)
        .HasForeignKey(x => x.ID_Empleado);

        builder.HasOne(x => x.Alquiler)
        .WithMany(x => x.Registro_Entregas)
        .HasForeignKey(x => x.ID_Alquiler);
    }
}