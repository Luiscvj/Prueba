using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class AlquilerRepository : RepositoryGeneric<Alquiler>,IAlquiler
{
     protected readonly TallerContext _context;

     public AlquilerRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}