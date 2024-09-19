// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Atores>().HasData(
        new Atores { Id = 1, PrimeiroNome = "Ator", UltimoNome = "Um", Genero = "Masculino" },
        new Atores { Id = 2, PrimeiroNome = "Ator", UltimoNome = "Dois", Genero = "Masculino" }
    );

    modelBuilder.Entity<Generos>().HasData(
        new Generos { Id = 1, Genero = "Ação" },
        new Generos { Id = 2, Genero = "Aventura" }
    );

    modelBuilder.Entity<Filmes>().HasData(
        new Filmes { Id = 1, Nome = "Filme Exemplo", Ano = 2023, Duracao = 120 }
    );

    modelBuilder.Entity<ElencoFilmes>().HasData(
        new ElencoFilmes { Id = 1, IdAtor = 1, IdFilmes = 1, Papel = "Protagonista" },
        new ElencoFilmes { Id = 2, IdAtor = 2, IdFilmes = 1, Papel = "Secundário" }
    );

    modelBuilder.Entity<FilmesGeneros>().HasData(
        new FilmesGeneros { Id = 1, IdGenero = 1, IdFilmes = 1 },
        new FilmesGeneros { Id = 2, IdGenero = 2, IdFilmes = 1 }
    );
}




public void AdicionarRegistro(
    string primeiroNomeAtor,
    string ultimoNomeAtor,
    string generoAtor,
    string nomeFilme,
    int anoFilme,
    int duracaoFilme,
    string papelAtor,
    List<string> generosFilme)
{
    using (var context = new SeuDbContext())
    {
        // Criar ator
        var ator = new Atores
        {
            PrimeiroNome = primeiroNomeAtor,
            UltimoNome = ultimoNomeAtor,
            Genero = generoAtor
        };

        // Criar filme
        var filme = new Filmes
        {
            Nome = nomeFilme,
            Ano = anoFilme,
            Duracao = duracaoFilme,
            ElencoFilmes = new List<ElencoFilmes>
            {
                new ElencoFilmes { Atores = ator, Papel = papelAtor }
            },
            FilmesGeneros = new List<FilmesGeneros>()
        };

        // Criar gêneros e relacioná-los ao filme
        foreach (var nomeGenero in generosFilme)
        {
            var genero = new Generos { Genero = nomeGenero };
            filme.FilmesGeneros.Add(new FilmesGeneros { Genero = genero });
        }

        // Adicionar todos ao contexto
        context.Atores.Add(ator);
        context.Filmes.Add(filme);
        context.SaveChanges();
    }
}