static void Main(string[] args)
{
    //AdicionarAtor();
    //ConsultarAtores();

    //AdicionarFilme();
    //ConsultarFilmes();

    //AdicionarGenero();
    //ConsultarGeneros();

    //AdicionarElencoFilme();
    //ConsultarElencoFilmes();

    //AdicionarFilmesGeneros();
    //ConsultarFilmesGeneros();
}

public class RepositorioGenerico<T> where T : class
{
    private readonly Data.ApplicationContext _contextoDb; // Contexto do banco de dados
    private readonly DbSet<T> _conjuntoDb; // Conjunto de dados da entidade T

    // Construtor do repositório genérico
    public RepositorioGenerico()
    {
        _contextoDb = new Data.ApplicationContext(); // Inicializa o contexto
        _conjuntoDb = _contextoDb.Set<T>(); // Define o conjunto de dados para a entidade T
    }

    // Método para adicionar uma nova entidade
    public void Adicionar(T entidade)
    {
        _conjuntoDb.Add(entidade); // Adiciona a entidade ao conjunto
        _contextoDb.SaveChanges(); // Salva as alterações no banco de dados
    }

    // Método para buscar uma entidade pelo ID
    public T BuscarPorId(int id)
    {
        return _conjuntoDb.Find(id); // Retorna a entidade encontrada pelo ID
    }

    // Método para listar todas as entidades
    public IEnumerable<T> ListarTodos()
    {
        return _conjuntoDb.ToList(); // Retorna todas as entidades como uma lista
    }

    // Método para atualizar uma entidade existente
    public void Atualizar(T entidade)
    {
        _conjuntoDb.Update(entidade); // Atualiza a entidade no conjunto
        _contextoDb.SaveChanges(); // Salva as alterações no banco de dados
    }

    // Método para deletar uma entidade pelo ID
    public void Deletar(int id)
    {
        var entidade = BuscarPorId(id); // Busca a entidade pelo ID
        if (entidade != null) // Verifica se a entidade foi encontrada
        {
            _conjuntoDb.Remove(entidade); // Remove a entidade do conjunto
            _contextoDb.SaveChanges(); // Salva as alterações no banco de dados
        }
    }

    // Método para liberar recursos
    public void Liberar()
    {
        _contextoDb.Dispose(); // Libera o contexto do banco de dados
    }
}

private static void AdicionarAtor()
{
    using var repo = new GenericRepository<Atores>();

    var novoAtor = new Atores
    {
        PrimeiroNome = "Nome do Ator",
        UltimoNome = "Sobrenome do Ator",
        Genero = "Gênero"
    };

    repo.Add(novoAtor);
    Console.WriteLine("Ator adicionado com sucesso!");
}

private static void AtualizarAtor(int id, string novoPrimeiroNome)
{
    using var repo = new GenericRepository<Atores>();

    var ator = repo.GetById(id);
    if (ator != null)
    {
        ator.PrimeiroNome = novoPrimeiroNome;
        repo.Update(ator);
        Console.WriteLine("Primeiro nome do ator atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Ator não encontrado.");
    }
}

private static void ConsultarAtores()
{
    using var repo = new GenericRepository<Atores>();

    var atores = repo.GetAll();
    foreach (var ator in atores)
    {
        Console.WriteLine($"{ator.PrimeiroNome} {ator.UltimoNome}");
    }
}
private static void AdicionarFilme()
{
    using var repo = new GenericRepository<Filmes>();

    var novoFilme = new Filmes
    {
        Nome = "Nome do Filme",
        Ano = 2023,
        Duracao = 120 // Duração em minutos
    };

    repo.Add(novoFilme);
    Console.WriteLine("Filme adicionado com sucesso!");
}

private static void AtualizarFilme(int id, string novoNome)
{
    using var repo = new GenericRepository<Filmes>();

    var filme = repo.GetById(id);
    if (filme != null)
    {
        filme.Nome = novoNome;
        repo.Update(filme);
        Console.WriteLine("Filme atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Filme não encontrado.");
    }
}

private static void ConsultarFilmes()
{
    using var repo = new GenericRepository<Filmes>();

    var filmes = repo.GetAll();
    foreach (var filme in filmes)
    {
        Console.WriteLine($"Filme: {filme.Nome}, Ano: {filme.Ano}");
    }
}
private static void AdicionarGenero()
{
    using var repo = new GenericRepository<Generos>();

    var novoGenero = new Generos
    {
        Genero = "Nome do Gênero"
    };

    repo.Add(novoGenero);
    Console.WriteLine("Gênero adicionado com sucesso!");
}

private static void AtualizarGenero(int id, string novoNome)
{
    using var repo = new GenericRepository<Generos>();

    var genero = repo.GetById(id);
    if (genero != null)
    {
        genero.Genero = novoNome;
        repo.Update(genero);
        Console.WriteLine("Gênero atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Gênero não encontrado.");
    }
}

private static void ConsultarGeneros()
{
    using var repo = new GenericRepository<Generos>();

    var generos = repo.GetAll();
    foreach (var genero in generos)
    {
        Console.WriteLine($"Gênero: {genero.Genero}");
    }
}
private static void AdicionarElencoFilme()
{
    using var repo = new GenericRepository<ElencoFilmes>();

    var novoElenco = new ElencoFilmes
    {
        IdAtor = 1, // ID do ator
        IdFilmes = 1, // ID do filme
        Papel = "Papel do Ator"
    };

    repo.Add(novoElenco);
    Console.WriteLine("Elenco adicionado com sucesso!");
}

private static void AtualizarElencoFilme(int id, string novoPapel)
{
    using var repo = new GenericRepository<ElencoFilmes>();

    var elenco = repo.GetById(id);
    if (elenco != null)
    {
        elenco.Papel = novoPapel;
        repo.Update(elenco);
        Console.WriteLine("Papel do ator atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Elenco não encontrado.");
    }
}

private static void ConsultarElencoFilmes()
{
    using var repo = new GenericRepository<ElencoFilmes>();

    var elenco = repo.GetAll();
    foreach (var item in elenco)
    {
        Console.WriteLine($"Ator ID: {item.IdAtor}, Filme ID: {item.IdFilmes}, Papel: {item.Papel}");
    }
}
private static void AdicionarFilmesGeneros()
{
    using var repo = new GenericRepository<FilmesGeneros>();

    var novoFilmeGenero = new FilmesGeneros
    {
        IdFilmes = 1, // ID do filme
        IdGenero = 1 // ID do gênero
    };

    repo.Add(novoFilmeGenero);
    Console.WriteLine("Associação de filme e gênero adicionada com sucesso!");
}

private static void ConsultarFilmesGeneros()
{
    using var repo = new GenericRepository<FilmesGeneros>();

    var filmesGeneros = repo.GetAll();
    foreach (var item in filmesGeneros)
    {
        Console.WriteLine($"Filme ID: {item.IdFilmes}, Gênero ID: {item.IdGenero}");
    }
}
