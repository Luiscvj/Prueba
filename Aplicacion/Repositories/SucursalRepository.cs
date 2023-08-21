using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class SucursalRepository : RepositoryGeneric<Sucursal>,ISucursal
{
     protected readonly TallerContext _context;

     public SucursalRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}