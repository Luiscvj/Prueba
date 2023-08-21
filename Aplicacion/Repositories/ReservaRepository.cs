using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class ReservaRepository : RepositoryGeneric<Reserva>,IReserva
{
     protected readonly TallerContext _context;

     public ReservaRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}