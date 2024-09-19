// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class Program
{
    {
        // Adiciona um ator
        var ator = AdicionarAtor("Jeferson", "Naressi", "Masculino");

        // Adiciona um filme
        var filme = AdicionarFilme("Filme Exemplo", 2023, 120);

        // Adiciona gêneros e associa ao filme
        var generos = new List<string> { "Ação", "Aventura" };
        AdicionarFilmeComGeneros(filme.Nome, filme.Ano, filme.Duracao, generos);

        // Adiciona o ator ao elenco do filme
        AdicionarElenco(ator, filme, "Protagonista");

        Console.WriteLine("Registros adicionados com sucesso!");
    }

    public static Atores AdicionarAtor(string primeiroNome, string ultimoNome, string genero)
    {
        var ator = new Atores
        {
            PrimeiroNome = primeiroNome,
            UltimoNome = ultimoNome,
            Genero = genero
        };

        using (var context = new SeuDbContext())
        {
            context.Atores.Add(ator);
            context.SaveChanges();
        }
        return ator;
    }

    public static Filmes AdicionarFilme(string nomeFilme, int anoFilme, int duracaoFilme)
    {
        var filme = new Filmes
        {
            Nome = nomeFilme,
            Ano = anoFilme,
            Duracao = duracaoFilme
        };

        using (var context = new SeuDbContext())
        {
            context.Filmes.Add(filme);
            context.SaveChanges();
        }
        return filme;
    }

    public static void AdicionarFilmeComGeneros(string nomeFilme, int anoFilme, int duracaoFilme, List<string> generosFilme)
    {
        var filme = AdicionarFilme(nomeFilme, anoFilme, duracaoFilme);

        using (var context = new SeuDbContext())
        {
            foreach (var nomeGenero in generosFilme)
            {
                var genero = new Generos { Genero = nomeGenero };
                context.Generos.Add(genero);
                context.FilmesGeneros.Add(new FilmesGeneros { Filme = filme, Genero = genero });
            }
            context.SaveChanges();
        }
    }

    public static ElencoFilmes AdicionarElenco(Atores ator, Filmes filme, string papel)
    {
        var elenco = new ElencoFilmes
        {
            Atores = ator,
            Filme = filme,
            Papel = papel
        };

        using (var context = new SeuDbContext())
        {
            context.ElencoFilmes.Add(elenco);
            context.SaveChanges();
        }
        return elenco;
    }
}

