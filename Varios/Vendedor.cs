namespace Varios;

public class Vendedor
{
    private int IdVendedor ;
    private string  Nombre ;
    private double premio ;
    public double Total {get; private set;}
    List<Venta>Ventas{get; set;}
    public Vendedor (int IdVendedor,string Nombre)
    {
        this.IdVendedor=IdVendedor;
        this.Nombre=Nombre;
        this.Ventas= new List<Venta>();
    }
    public void AddVenta(Venta venta)
    {
        Ventas.Add(venta);
    }
    public void PremiarVendedor()
    {
        premio=Total*0.05 %100;
    }
    public void MostarVendedor()
    {   
        var t=Ventas.Sum(x=>x.Precio);
        Total=t;
        System.Console.WriteLine($"Nombre del Vendedor{Nombre},Total de Ventas{Total}");
        foreach (var item in Ventas)
        {
            System.Console.WriteLine($"precio de cada venta: {item}");
        }
    }

}
