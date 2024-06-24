namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*string nomeCompleto = "Jeferson Naressi";

        Func<char, bool> filtro = c => c == 'A';

        //var resultado = nomeCompleto.Where(filtro);
        //var resultado = nomeCompleto.Where(p => p == 'A');
        
        var resultado = from c in nomeCompleto where c == 'E' select c;

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10);
        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
 
    public void AulaOrdenacao()
    {
        //var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        var nomes = new string[] { "Jeferson", "Lucas", "Pedro"};
        //var resultado = numeros.OrderByDescending(p => p);
        var resultado = nomes.OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] { 4, 12 , 9, 43, 76, 48};
        
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }
    
    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] { 10, 6 , 5, 50, 15, 2};
        
        //var resultado = numeros.First();
        //var resultado = numeros.First(p => p > 100);
        var resultado = numeros.FirstOrDefault(p => p > 100, -99);
 
        Console.WriteLine(resultado);
    }
}