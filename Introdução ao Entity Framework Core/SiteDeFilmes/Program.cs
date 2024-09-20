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

    // Adicionar relações de elenco
    var elenco1 = new ElencoFilmes { IdAtor = ator1.Id, IdFilmes = filme1.Id, Papel = "Cobb" };
    var elenco2 = new ElencoFilmes { IdAtor = ator2.Id, IdFilmes = filme2.Id, Papel = "Miranda" };
    context.ElencoFilmes.AddRange(elenco1, elenco2);
    context.SaveChanges();

    // Associar gêneros aos filmes
    var filmeGenero1 = new FilmesGeneros { IdFilmes = filme1.Id, IdGenero = generoAcao.Id };
    var filmeGenero2 = new FilmesGeneros { IdFilmes = filme2.Id, IdGenero = generoComedia.Id };
    context.FilmesGeneros.AddRange(filmeGenero1, filmeGenero2);
    context.SaveChanges();
}
}
}
