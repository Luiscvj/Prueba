using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class Registro_DevolucionRepository : RepositoryGeneric<Registro_Devolucion>,IRegistro_Devolucion
{
     protected readonly TallerContext _context;

     public Registro_DevolucionRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}