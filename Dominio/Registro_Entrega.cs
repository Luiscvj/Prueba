public class Registro_Entrega
{
    public int ID_Registro { get; set; }
    public DateTime Fecha_Entrega { get; set; }
    public decimal Combustible_Entregado { get; set; }
    public int Kilometraje_Entregado { get; set; }
    public int ID_Alquiler { get; set; }
    public Alquiler Alquiler { get; set; }
    public int ID_Empleado { get; set; }
    public Empleado Empleado { get; set; }
}