namespace Dominio.Interfaces;


public interface IUnitOfWork 
{
    public IAlquiler Alquileres {get;}
    public IAutomovil Automoviles {get;}
    public ICliente Clientes {get;}
    public IEmpleado Empleados {get;}
    public IRegistro_Devolucion  Registro_Devoluciones {get;}
    public IRegistro_Entrega Registro_Entregas  {get;}
    public IReserva Reservas {get;}
    public ISucursal_Automovil Sucursal_Automoviles   {get;}
    public ISucursal Sucursales  {get;}

    Task<int> SaveChanges();

}