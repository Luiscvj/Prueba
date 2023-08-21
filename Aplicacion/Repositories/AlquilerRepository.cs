namespace Aplicacion.Repositories;


public class AlquilerRepository : RepositoryGeneric<Alquiler>
{
     protected readonly TallerContext _context;

     public AlquilerRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}