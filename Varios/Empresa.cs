namespace Varios;

public class Empresa
{
    List<Tienda>tiendas{get; set; }
    public void AddTienda(Tienda tienda)
    {
        tiendas.Add(tienda);
    }
    public void MostarTienda()
    {

        var maximo = tiendas.Max();
        
    }
}
