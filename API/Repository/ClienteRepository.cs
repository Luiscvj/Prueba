using Dominio.Interfaces;

namespace API.Repository;

public class ClienteRepositry : RepositoryGeneric<Cliente>
{
    public ClienteRepositry(PruebaContext context) : base(context)
    {
    }
}