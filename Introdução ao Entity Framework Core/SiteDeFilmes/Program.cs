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
        Papel = "Papel"
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
private static void ConsultarFilmePorId(int id)
{
    using var db = new Data.ApplicationContext();

    var filme = db.Filmes.Find(id); // Busca pelo ID

    if (filme != null)
    {
        Console.WriteLine($"Filme encontrado: {filme.Nome}, Ano: {filme.Ano}, Duração: {filme.Duracao}");
    }
    else
    {
        Console.WriteLine("Filme não encontrado.");
    }
}

private static void ConsultarFilmePorNome(string nome)
{
    using var db = new Data.ApplicationContext();

    var filme = db.Filmes.FirstOrDefault(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)); // Busca pelo nome

    if (filme != null)
    {
        Console.WriteLine($"Filme encontrado: {filme.Nome}, Ano: {filme.Ano}, Duração: {filme.Duracao}");
    }
    else
    {
        Console.WriteLine("Filme não encontrado.");
    }
}
private static void ConsultarAtorPorId(int id)
{
    using var db = new Data.ApplicationContext();

    var ator = db.Atores.Find(id); // Busca pelo ID

    if (ator != null)
    {
        Console.WriteLine($"Ator encontrado: {ator.PrimeiroNome} {ator.UltimoNome}, Gênero: {ator.Genero}");
    }
    else
    {
        Console.WriteLine("Ator não encontrado.");
    }
}

private static void ConsultarAtorPorNome(string primeiroNome, string ultimoNome)
{
    using var db = new Data.ApplicationContext();

    var ator = db.Atores.FirstOrDefault(a => 
        a.PrimeiroNome.Equals(primeiroNome, StringComparison.OrdinalIgnoreCase) && 
        a.UltimoNome.Equals(ultimoNome, StringComparison.OrdinalIgnoreCase));

    if (ator != null)
    {
        Console.WriteLine($"Ator encontrado: {ator.PrimeiroNome} {ator.UltimoNome}, Gênero: {ator.Genero}");
    }
    else
    {
        Console.WriteLine("Ator não encontrado.");
    }
}

private static void ConsultarGeneroPorId(int id)
{
    using var db = new Data.ApplicationContext();

    var genero = db.Generos.Find(id); // Busca pelo ID

    if (genero != null)
    {
        Console.WriteLine($"Gênero encontrado: {genero.Genero}");
    }
    else
    {
        Console.WriteLine("Gênero não encontrado.");
    }
}

private static void ConsultarElencoPorFilmeId(int idFilme)
{
    using var db = new Data.ApplicationContext();

    var elenco = db.ElencoFilmes.Where(e => e.IdFilmes == idFilme).ToList();

    if (elenco.Any())
    {
        foreach (var item in elenco)
        {
            Console.WriteLine($"Ator ID: {item.IdAtor}, Papel: {item.Papel}");
        }
    }
    else
    {
        Console.WriteLine("Nenhum elenco encontrado para este filme.");
    }
}
private static void ConsultarFilmesPorGeneroId(int idGenero)
{
    using var db = new Data.ApplicationContext();

    var filmesGeneros = db.FilmesGeneros.Where(fg => fg.IdGenero == idGenero).ToList();

    if (filmesGeneros.Any())
    {
        foreach (var item in filmesGeneros)
        {
            var filme = db.Filmes.Find(item.IdFilmes);
            Console.WriteLine($"Filme ID: {filme.Id}, Nome: {filme.Nome}, Ano: {filme.Ano}, Duração: {filme.Duracao}");
        }
    }
    else
    {
        Console.WriteLine("Nenhum filme encontrado para este gênero.");
    }
}
