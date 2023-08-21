public class Reserva
{
    public int ID_Reserva { get; set; }
    public int ID_Cliente { get; set; }
    public Cliente Cliente { get; set; }
    public int ID_Automovil { get; set; }
    public Automovil Automovil { get; set; }
    public DateTime Fecha_Reserva { get; set; }
    public DateTime Fecha_Inicio { get; set; }
    public DateTime Fecha_Fin { get; set; }
    public string Estado { get; set; }
}