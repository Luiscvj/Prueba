public class Alquiler
{
public int  ID_Alquiler { get; set; }
public DateTime Fecha_Inicio { get; set; }
public DateTime Fecha_Fin { get; set; }
public decimal Costo_Total { get; set; }
public string Estado { get; set; }
public int ID_Cliente { get; set; }
public Cliente Cliente { get; set; }
public int ID_Automovil { get; set; }
public Automovil Automovil { get; set; }
public List<Registro_Entrega> Registro_Entregas { get; set; }
public List<Registro_Devolucion> Registro_Devoluciones { get; set; }

}