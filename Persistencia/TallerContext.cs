
using System.Reflection;
using Microsoft.EntityFrameworkCore;
public class TallerContext : DbContext
{
    public TallerContext(DbContextOptions<TallerContext> options) : base(options)
    {

    }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}