//List<int>Numeros=new List<int>{1,12,498,65,46,62,15,7,8,4,98,9,5,};

// int MyProperty =Numeros.Sum();
// Numeros.Sort();
// Numeros.Reverse();
// var thefive=Numeros.Take(5); 
// foreach (var item in thefive)
// {
//     System.Console.WriteLine(item);
// }
using Varios;
Tienda tienda = new Tienda(1);

System.Console.WriteLine("id ");
int i = Convert.ToInt32(Console.ReadLine());
for (int x = 0; x < 8; x++)
{
    System.Console.WriteLine("ingresar nombre");
    string nombre = Console.ReadLine();
    Vendedor vendedor = new Vendedor(i, nombre);
    System.Console.WriteLine("ingresar venta");
    int 
    Venta venta = new Venta(x, 78);
    while()
    {

    }
    
}


Venta venta1 = new Venta(2, 78);
vendedor.AddVenta(venta);
vendedor.AddVenta(venta1);
tienda.AddVendedor(vendedor);
tienda.Mostar();