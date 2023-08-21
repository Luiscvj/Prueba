using Dominio.Interfaces;

namespace Aplicacion.Repositories;


public class EmpleadoRepository : RepositoryGeneric<Empleado>,IEmpleado
{
     protected readonly TallerContext _context;

     public EmpleadoRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}