namespace Varios;

public class Venta
{
    public int IdVenta{get; set;}
    public Zona Zona { get; set; }
    public double Precio{get; set;} 
    public Venta(int IdVenta,double Precio)
    {
        this.IdVenta=IdVenta;
        this.Precio=Precio;
    }
}
public class Zona
{
    public string  zona { get; set; }
    public Zona(string Zona){
        this.zona=zona;
    }
}
