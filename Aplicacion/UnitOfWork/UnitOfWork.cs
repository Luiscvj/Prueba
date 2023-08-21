using Aplicacion.Repositories;
using Dominio.Interfaces;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{

    private readonly TallerContext _context;
    public UnitOfWork(TallerContext context)
        {
            _context = context;
        }


    private AlquilerRepository _alquiler ;
    private AutomovilRepository _automovil;
    private ClienteRepository _cliente;
    private EmpleadoRepository _empleado;
    private Registro_DevolucionRepository _registro_Devolucion;
    private Registro_EntregaRepository _registro_Entrega;
    private ReservaRepository _reserva;
    private Sucursal_AutomovilRepository _sucursal_Automovil;
    private SucursalRepository _sucursal;


    

    public IAlquiler Alquileres 
    {
        get
        {
            if(_alquiler == null)
            {
                _alquiler = new AlquilerRepository(_context);
            }
            return  _alquiler;        
        }    
    }

    public IAutomovil Automoviles 
    {
        get
        {
            if(_automovil == null)
            {
              _automovil  = new AutomovilRepository(_context);
            }
            return  _automovil;
        }
    }

    public ICliente Clientes 
    {
        get
        {
            if(_cliente == null)
            {
               _cliente = new ClienteRepository(_context);
            }
            return _cliente;
        }
    }

    public IEmpleado Empleados 
    {
        get
        {
            if(_empleado == null)
            {
               _empleado = new EmpleadoRepository(_context);
            }
            return  _empleado;
        }
    }

    public IRegistro_Devolucion Registro_Devoluciones 
    {
        get
        {
            if(_registro_Devolucion == null)
            {
               _registro_Devolucion = new Registro_DevolucionRepository(_context);
            }
            return _registro_Devolucion;
        }
    }

    public IRegistro_Entrega Registro_Entregas 
    {
        get
        {
            if(_registro_Entrega == null)
            {
               _registro_Entrega = new Registro_EntregaRepository(_context);
            }
            return _registro_Entrega;
        }
    }

    public IReserva Reservas 
    {
        get
        {
            if(_reserva == null)
            {
               _reserva = new ReservaRepository(_context);
            }
            return _reserva;
        }
    }

    public ISucursal_Automovil Sucursal_Automoviles 
    {
        get
        {
            if(_sucursal_Automovil == null)
            {
               _sucursal_Automovil = new Sucursal_AutomovilRepository(_context);    
            }
            return _sucursal_Automovil;
        }
    }

    public ISucursal Sucursales 
    {
        get
        {
            if(_sucursal == null)
            {
               _sucursal = new SucursalRepository(_context);
            }
            return _sucursal;
        }
    }

    public async Task<int> SaveChanges()
    {
         return await _context.SaveChangesAsync();
    }
}