namespace Aplicacion.Repositories;


public class ReservaRepository : RepositoryGeneric<Reserva>
{
     protected readonly TallerContext _context;

     public ReservaRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}