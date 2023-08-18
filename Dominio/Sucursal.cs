public class Sucursal
{
    public int ID_Sucursal { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Automovil> Automoviles { get; set; }
    public List<Sucursal_Automovil> Sucursal_Automoviles { get; set; }
}