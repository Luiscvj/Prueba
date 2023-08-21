namespace Aplicacion.Repositories;


public class EmpleadoRepository : RepositoryGeneric<Empleado>
{
     protected readonly TallerContext _context;

     public EmpleadoRepository(TallerContext context) :base(context)
     {
        _context = context;
     }
}