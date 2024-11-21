using System.Runtime.CompilerServices;

namespace Varios;

public class Tienda
{
    private int IdTienda { get; set; }
    private string Zona { get; set; }
    List<Vendedor>Vendedores { get; set; }
    public double Total{ get; private set; } 
    public Tienda (int IdTienda,string Zona)
    {
        this.IdTienda=IdTienda;
        this.Zona=Zona;
        Vendedores=new List<Vendedor>();
    }
    public void AddVendedor(Vendedor vendedor)
    {
        if(Vendedores.Count<9)
        Vendedores.Add(vendedor);

    }
    public void Mostar()
    {
        foreach (var item in Vendedores)
        {   
            Total+=item.Total;
        }
        System.Console.WriteLine($"{Zona}m{Total}");
    }
}
