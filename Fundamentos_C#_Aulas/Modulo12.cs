namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }  

    public void AulaTratandoException()
    {
        while(true)
        {
            try
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
            catch(DivideByZeroException exeception)
            {
                Console.WriteLine("Ocorreu um erro de divisao: " + exeception.Message);
                Console.WriteLine("Stack: " + exeception.StackTrace);
            }
            catch(Exception exeception)
            {
               Console.WriteLine("Ocorreu um erro: " + exeception.Message);
               Console.WriteLine("Stack: " + exeception.StackTrace);
            }
 
        }
    }  
}