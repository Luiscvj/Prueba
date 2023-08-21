using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class Registro_EntregaRepository : RepositoryGeneric<Registro_Entrega>,IRegistro_Entrega
{
     protected readonly TallerContext _context;

     public Registro_EntregaRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}