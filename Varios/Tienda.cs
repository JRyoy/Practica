using System.Runtime.CompilerServices;

namespace Varios;

public class Tienda
{
    private int IdTienda { get; set; }
    public List<Vendedor>Vendedores { get; set; }
    public Tienda (int IdTienda)
    {
        this.IdTienda=IdTienda;
        Vendedores=new List<Vendedor>();
    }
    public void AddVendedor(Vendedor vendedor)
    {
        if(Vendedores.Count<9)
        Vendedores.Add(vendedor);

    }
    public void Mostar()
    {
        System.Console.WriteLine($"Tirnda: {IdTienda}");
        foreach (var item in Vendedores)
        {
            item.MostarVendedor();

        }
        var mayor=Vendedores.Max(x=>x.Total);
        var ven=Vendedores.Where(X=>X.Total==mayor);
        System.Console.WriteLine(mayor);
    }   
}
