// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Program
{
    (var context = new AppDbContext())

    // Adicionar gêneros de filmes
    var generoAcao = new Generos { Genero = "Ação" };
    var generoComedia = new Generos { Genero = "Comédia" };
    context.Generos.AddRange(generoAcao, generoComedia);
    context.SaveChanges();

    // Adicionar atores
    var ator1 = new Atores { PrimeiroNome = "Leonardo", UltimoNome = "DiCaprio", Genero = "Masculino" };
    var ator2 = new Atores { PrimeiroNome = "Meryl", UltimoNome = "Streep", Genero = "Feminino" };
    context.Atores.AddRange(ator1, ator2);
    context.SaveChanges();

    // Adicionar filmes
    var filme1 = new Filmes { Nome = "Inception", Ano = 2010, Duracao = 148 };
    var filme2 = new Filmes { Nome = "The Devil Wears Prada", Ano = 2006, Duracao = 109 };
    context.Filmes.AddRange(filme1, filme2);
    context.SaveChanges();

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
