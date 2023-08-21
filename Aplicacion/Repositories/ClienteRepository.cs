namespace Aplicacion.Repositories;


public class ClienteRepository : RepositoryGeneric<Cliente>
{
     protected readonly TallerContext _context;

     public ClienteRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}