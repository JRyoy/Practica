List<int>Numeros=new List<int>{1,12,498,65,46,62,15,7,8,4,98,9,5,};

int MyProperty =Numeros.Sum();
Numeros.Sort();
Numeros.Reverse();
var thefive=Numeros.Take(5); 
foreach (var item in thefive)
{
    System.Console.WriteLine(item);
}
