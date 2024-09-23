// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using (var context = new FilmeContext())
{
    // Adicionando Gêneros
    var acao = new Generos { Genero = "Ação" };
    var comedia = new Generos { Genero = "Comédia" };
    context.Generos.AddRange(acao, comedia);
    context.SaveChanges();

    // Adicionando Atores
    var ator1 = new Atores { PrimeiroNome = "Jeferson", UltimoNome = "Naressi", Genero = "Masculino" };
    var ator2 = new Atores { PrimeiroNome = "Jane", UltimoNome = "Lys", Genero = "Feminino" };
    context.Atores.AddRange(ator1, ator2);
    context.SaveChanges();

    // Adicionando Filmes
    var filme1 = new Filmes { Nome = "Aventura Incrível", Ano = 2022, Duracao = 120 };
    var filme2 = new Filmes { Nome = "Riso Garantido", Ano = 2023, Duracao = 90 };
    context.Filmes.AddRange(filme1, filme2);
    context.SaveChanges();

    // Adicionando Elenco
    context.ElencoFilmes.AddRange(
        new ElencoFilmes { IdAtor = ator1.Id, IdFilmes = filme1.Id, Papel = "Heroi" },
        new ElencoFilmes { IdAtor = ator2.Id, IdFilmes = filme2.Id, Papel = "Protagonista" }
    );
    context.SaveChanges();

    // Associando Filmes e Gêneros
    context.FilmesGeneros.AddRange(
        new FilmesGeneros { IdFilmes = filme1.Id, IdGenero = acao.Id },
        new FilmesGeneros { IdFilmes = filme2.Id, IdGenero = comedia.Id }
    );
    context.SaveChanges();
}
private static void ConsultarDados()
{
    using var db = new Data.ApplicationContext();
    //var consultarPorSintaxe = (from c in db.filmes where c.Id>0 select c).ToList();
    var ConsultaPorMetodo = db.Filmes.Where(p =>p.Id >0).ToList();
    foreach(var Filmes in ConsultaPorMetodo)
    {
        db.Filmes.Find(Filme.Id) //Find consulta primeiro em memoria caso não encontre procura no bd
    }
    
}
