using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReservaConfigurations : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.ToTable("reserva");

        builder.HasKey(x => x.Id_Reserva);

        builder.Property(x => x.Fecha_Reserva)
        .HasColumnType("date");
        builder.Property(x => x.Fecha_Inicio)
        .HasColumnType("date");
        builder.Property(x => x.Fecha_Fin)
        .HasColumnType("date");

        builder.Property(x => x.Estado)
        .HasMaxLength(50);

        builder.HasOne(x => x.Cliente)
        .WithMany(x => x.Reservas)
        .HasForeignKey(x => x.ID_Cliente);

        builder.HasOne(x => x.Automovil)
        .WithMany(x => x.Reservas)
        .HasForeignKey(x => x.ID_Automovil);


    }
}