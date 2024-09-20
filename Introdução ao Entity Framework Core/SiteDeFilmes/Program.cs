// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Program
{

public static Atores AdicionarAtor(string primeiroNome, string ultimoNome, string genero)
{
    var ator = new Atores
    {
        PrimeiroNome = primeiroNome,
        UltimoNome = ultimoNome,
        Genero = genero
    };
    
    return Adicionar(ator);
}

public static Filmes AdicionarFilme(string nomeFilme, int anoFilme, int duracaoFilme)
{
    var filme = new Filmes
    {
        Nome = nomeFilme,
        Ano = anoFilme,
        Duracao = duracaoFilme
    };
    
    return Adicionar(filme);
}

public static T Adicionar<T>(T entidade) where T : class
{
    using (var context = new SeuDbContext())
    {
        context.Set<T>().Add(entidade);
        context.SaveChanges();
    }
    return entidade;
}



// Supondo que a classe Atores já está definida
var novoAtor = new Atores
{
    PrimeiroNome = "Jeferson",
    UltimoNome = "Naressi",
    Genero = "Masculino"
};

// Chamada do método genérico para adicionar o ator
novoAtor = Adicionar(novoAtor);
