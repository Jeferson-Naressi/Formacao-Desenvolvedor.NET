private static void AdicionarAtor()
{
    using var db = new Data.ApplicationContext();

    var novoAtor = new Atores
    {
        PrimeiroNome = "Nome do Ator",
        UltimoNome = "Sobrenome do Ator",
        Genero = "Gênero"
    };

    db.Atores.Add(novoAtor);
    db.SaveChanges();

    Console.WriteLine("Ator adicionado com sucesso!");
}

private static void AdicionarFilme()
{
    using var db = new Data.ApplicationContext();

    var novoFilme = new Filmes
    {
        Nome = "Nome do Filme",
        Ano = 2023,
        Duracao = 120 // Duração em minutos
    };

    db.Filmes.Add(novoFilme);
    db.SaveChanges();

    Console.WriteLine("Filme adicionado com sucesso!");
}

private static void AdicionarGenero()
{
    using var db = new Data.ApplicationContext();

    var novoGenero = new Generos
    {
        Genero = "Nome do Gênero"
    };

    db.Generos.Add(novoGenero);
    db.SaveChanges();

    Console.WriteLine("Gênero adicionado com sucesso!");
}

private static void AdicionarElenco(int idAtor, int idFilme, string papel)
{
    using var db = new Data.ApplicationContext();

    var novoElenco = new ElencoFilmes
    {
        IdAtor = idAtor,
        IdFilmes = idFilme,
        Papel = papel
    };

    db.ElencoFilmes.Add(novoElenco);
    db.SaveChanges();

    Console.WriteLine("Elenco adicionado com sucesso!");
}

private static void AssociarFilmeGenero(int idFilme, int idGenero)
{
    using var db = new Data.ApplicationContext();

    var novaAssociacao = new FilmesGeneros
    {
        IdFilmes = idFilme,
        IdGenero = idGenero
    };

    db.FilmesGeneros.Add(novaAssociacao);
    db.SaveChanges();

    Console.WriteLine("Filme e gênero associados com sucesso!");
}
