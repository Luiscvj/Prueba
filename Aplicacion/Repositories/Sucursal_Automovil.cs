namespace Aplicacion.Repositories;


public class Sucursal_AutomovilRepository : RepositoryGeneric<Sucursal_Automovil>
{
     protected readonly TallerContext _context;

     public Sucursal_AutomovilRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}