public class Cliente
{
    public int ID_Cliente { get; set; }
    public string Nombre { get; set; }
    public string    Apellido { get; set; }
    public string DNI { get; set; }
    public string    Direccion { get; set; }
    public string Telefono { get; set; }
    public string    Email { get; set; }
    public List<Reserva> Reservas { get; set; }
    public List<Alquiler> Alquileres { get; set; }
  
}