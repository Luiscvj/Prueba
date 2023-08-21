namespace Aplicacion.Repositories;


public class AutomovilRepository : RepositoryGeneric<Automovil>
{
     protected readonly TallerContext _context;

     public AutomovilRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}