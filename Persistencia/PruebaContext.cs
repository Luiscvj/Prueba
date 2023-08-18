using System.Reflection;
using Microsoft.EntityFrameworkCore;

public class PruebaContext : DbContext
{
    public PruebaContext(DbContextOptions<PruebaContext> options) : base(options){}

    public DbSet<Automovil> Automoviles { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Registro_Devolucion> Registro_Devoluciones { get; set; }
    public DbSet<Registro_Entrega> Registro_Entregas { get; set; }
    public DbSet<Sucursal_Automovil> Sucursal_Automoviles { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Alquiler> Alquileres { get; set; }
  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}

}





