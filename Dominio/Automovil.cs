public class Automovil

{
    public int ID_Automovil { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public string Tipo { get; set; }
    public int Capacidad { get; set; } 
    public decimal Precio_Diario { get; set; }
    public List<Reserva> Reservas { get; set; }
    public List<Alquiler> Alquileres { get; set; }
    public List<Sucursal> Sucursales { get; set; }
    public List<Sucursal_Automovil> Sucursal_Automoviles { get; set; }
}