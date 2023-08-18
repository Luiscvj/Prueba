using Dominio.Interfaces;

namespace API.Repository;

public class AutomovilRepositry : RepositoryGeneric<Automovil>
{
    public AutomovilRepositry(PruebaContext context) : base(context)
    {
    }
}