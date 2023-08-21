namespace Aplicacion.Repositories;


public class SucursalRepository : RepositoryGeneric<Sucursal>
{
     protected readonly TallerContext _context;

     public SucursalRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}