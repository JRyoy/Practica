namespace Varios;

public class Venta
{
    public int IdVenta{get; set;}
    public double Precio{get; set;} 
    public Venta(int IdVenta,double Precio)
    {
        this.IdVenta=IdVenta;
        this.Precio=Precio;
    }
    

}
