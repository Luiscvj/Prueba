public class Sucursal_Automovil
{
    public int ID_Sucursal { get; set; }
    public Sucursal Sucursal { get; set; }
    public int ID_Automovil { get; set; }
    public Automovil Automovil { get; set; }

    public int Cantidad_Disponible { get; set; }
}