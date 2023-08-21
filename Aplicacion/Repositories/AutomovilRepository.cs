using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class AutomovilRepository : RepositoryGeneric<Automovil>,IAutomovil
{
     protected readonly TallerContext _context;

     public AutomovilRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}