using Dominio.Interfaces;

namespace API.Repository;

public class ReservaRepositry : RepositoryGeneric<Reserva>
{
    public ReservaRepositry(PruebaContext context) : base(context)
    {
    }
}