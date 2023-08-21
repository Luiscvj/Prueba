using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.ToTable("reserva");
        builder.HasKey(x => x.ID_Reserva);

        builder.Property(x => x.Fecha_Reserva)
        .HasColumnType("date");

        builder.Property(x => x.Fecha_Fin)
        .HasColumnType("date");

        builder.Property(x => x.Fecha_Inicio)
        .HasColumnType("date");

        builder.Property(x => x.Estado)
        .HasMaxLength(50);


    }
}