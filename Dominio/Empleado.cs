public class Empleado 
{
    public int ID_Empleado   { get; set; }
    public string Nombre { get; set; }
    public string    Apellido { get; set; }
    public string DNI { get; set; }
    public string    Direccion { get; set; }
    public string Telefono { get; set; }
    public string Cargo { get; set; }
    public List<Registro_Devolucion> Registro_Devoluciones { get; set; }
    public List<Registro_Entrega> Registro_Entregas { get; set; }
}