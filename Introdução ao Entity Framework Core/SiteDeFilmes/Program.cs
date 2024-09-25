using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SiteDeFilmes.Data;
using SiteDeFilmes.Models;

namespace SiteDeFilmes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de uso
            AdicionarAtores(new List<Atores>
            {
                new Atores { PrimeiroNome = "Jeferson", UltimoNome = "Naressi", Genero = "M" },
                new Atores { PrimeiroNome = "Lucas", UltimoNome = "Amaro", Genero = "F" }
            });
            //ConsultarAtores();

            AdicionarFilmes(new List<Filmes>
            {
                new Filmes { Nome = "Eu sou a Lenda", Ano = 2023, Duracao = 120 },
                new Filmes { Nome = "Filme2", Ano = 2022, Duracao = 90 }
            });
            //ConsultarFilmes();

            AdicionarGeneros(new List<Generos>
            {
                new Generos { Genero = "Aventura" },
                new Generos { Genero = "Gênero2" }
            });
            

            //ConsultarGeneros();

            // Exemplo de atualização
            //AtualizarAtor(1, "NovoNome");
            //AtualizarFilme(1, "NovoFilme");
            //AtualizarGenero(1, "NovoGênero");
            //AtualizarElenco(1, "NovoPapel");
            //AtualizarFilmeGenero(1, 2);

            // Exemplo de exclusão
            //DeletarAtor(1);
            //DeletarFilme(1);
            //DeletarGenero(1);
            //DeletarElenco(1);
            //DeletarFilmeGenero(1);

            // Consultas após atualizações e exclusões
            //ConsultarAtores();
            //ConsultarFilmes();
            //ConsultarGeneros();
            //ConsultarElenco();
            //ConsultarFilmesGeneros();
            
        }

        // CRUD Atores
        private static void AdicionarAtores(IEnumerable<Atores> atores)
        {
            using var context = new ApplicationContext();
            context.Atores.AddRange(atores);
            context.SaveChanges();
            Console.WriteLine("Atores adicionados com sucesso!");
        }

        private static void ConsultarAtores()
        {
            using var context = new ApplicationContext();
            var atores = context.Atores.ToList();
            foreach (var ator in atores)
            {
                Console.WriteLine($"{ator.PrimeiroNome} {ator.UltimoNome}");
            }
        }

        private static void AtualizarAtor(int id, string novoNome)
        {
            using var context = new ApplicationContext();
            var ator = context.Atores.Find(id);
            if (ator != null)
            {
                ator.PrimeiroNome = novoNome;
                context.SaveChanges();
                Console.WriteLine("Ator atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Ator não encontrado.");
            }
        }

        private static void DeletarAtor(int id)
        {
            using var context = new ApplicationContext();
            var ator = context.Atores.Find(id);
            if (ator != null)
            {
                context.Atores.Remove(ator);
                context.SaveChanges();
                Console.WriteLine("Ator deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Ator não encontrado.");
            }
        }

        // CRUD Filmes
        private static void AdicionarFilmes(IEnumerable<Filmes> filmes)
        {
            using var context = new ApplicationContext();
            context.Filmes.AddRange(filmes);
            context.SaveChanges();
            Console.WriteLine("Filmes adicionados com sucesso!");
        }

        private static void ConsultarFilmes()
        {
            using var context = new ApplicationContext();
            var filmes = context.Filmes.ToList();
            foreach (var filme in filmes)
            {
                Console.WriteLine($"Filme: {filme.Nome}, Ano: {filme.Ano}");
            }
        }

        private static void AtualizarFilme(int id, string novoNome)
        {
            using var context = new ApplicationContext();
            var filme = context.Filmes.Find(id);
            if (filme != null)
            {
                filme.Nome = novoNome;
                context.SaveChanges();
                Console.WriteLine("Filme atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Filme não encontrado.");
            }
        }

        private static void DeletarFilme(int id)
        {
            using var context = new ApplicationContext();
            var filme = context.Filmes.Find(id);
            if (filme != null)
            {
                context.Filmes.Remove(filme);
                context.SaveChanges();
                Console.WriteLine("Filme deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Filme não encontrado.");
            }
        }

        // CRUD Generos
        private static void AdicionarGeneros(IEnumerable<Generos> generos)
        {
            using var context = new ApplicationContext();
            context.Generos.AddRange(generos);
            context.SaveChanges();
            Console.WriteLine("Gêneros adicionados com sucesso!");
        }

        private static void ConsultarGeneros()
        {
            using var context = new ApplicationContext();
            var generos = context.Generos.ToList();
            foreach (var gen in generos)
            {
                Console.WriteLine($"Gênero: {gen.Genero}");
            }
        }

        private static void AtualizarGenero(int id, string novoNome)
        {
            using var context = new ApplicationContext();
            var genero = context.Generos.Find(id);
            if (genero != null)
            {
                genero.Genero = novoNome;
                context.SaveChanges();
                Console.WriteLine("Gênero atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Gênero não encontrado.");
            }
        }

        private static void DeletarGenero(int id)
        {
            using var context = new ApplicationContext();
            var genero = context.Generos.Find(id);
            if (genero != null)
            {
                context.Generos.Remove(genero);
                context.SaveChanges();
                Console.WriteLine("Gênero deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Gênero não encontrado.");
            }
        }

        // CRUD ElencoFilmes
        private static void AdicionarElencos(IEnumerable<ElencoFilmes> elencos)
        {
            using var context = new ApplicationContext();
            context.ElencoFilmes.AddRange(elencos);
            context.SaveChanges();
            Console.WriteLine("Elencos adicionados com sucesso!");
        }

        private static void ConsultarElenco()
        {
            using var context = new ApplicationContext();
            var elenco = context.ElencoFilmes.ToList();
            foreach (var item in elenco)
            {
                Console.WriteLine($"Ator ID: {item.IdAtor}, Filme ID: {item.IdFilmes}, Papel: {item.Papel}");
            }
        }

        private static void AtualizarElenco(int id, string novoPapel)
        {
            using var context = new ApplicationContext();
            var elenco = context.ElencoFilmes.Find(id);
            if (elenco != null)
            {
                elenco.Papel = novoPapel;
                context.SaveChanges();
                Console.WriteLine("Papel do elenco atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Elenco não encontrado.");
            }
        }

        private static void DeletarElenco(int id)
        {
            using var context = new ApplicationContext();
            var elenco = context.ElencoFilmes.Find(id);
            if (elenco != null)
            {
                context.ElencoFilmes.Remove(elenco);
                context.SaveChanges();
                Console.WriteLine("Elenco deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Elenco não encontrado.");
            }
        }

        // CRUD FilmesGeneros
        private static void AdicionarFilmeGeneros(IEnumerable<FilmesGeneros> filmesGeneros)
        {
            using var context = new ApplicationContext();
            context.FilmesGeneros.AddRange(filmesGeneros);
            context.SaveChanges();
            Console.WriteLine("Associações de filme e gênero adicionadas com sucesso!");
        }

        private static void ConsultarFilmesGeneros()
        {
            using var context = new ApplicationContext();
            var filmesGeneros = context.FilmesGeneros.ToList();
            foreach (var item in filmesGeneros)
            {
                Console.WriteLine($"Filme ID: {item.IdFilmes}, Gênero ID: {item.IdGenero}");
            }
        }

        private static void AtualizarFilmeGenero(int id, int novoIdGenero)
        {
            using var context = new ApplicationContext();
            var filmeGenero = context.FilmesGeneros.Find(id);
            if (filmeGenero != null)
            {
                filmeGenero.IdGenero = novoIdGenero; // Atualiza o gênero associado
                context.SaveChanges();
                Console.WriteLine("Associação de filme e gênero atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Associação não encontrada.");
            }
        }

        private static void DeletarFilmeGenero(int id)
        {
            using var context = new ApplicationContext();
            var filmeGenero = context.FilmesGeneros.Find(id);
            if (filmeGenero != null)
            {
                context.FilmesGeneros.Remove(filmeGenero);
                context.SaveChanges();
                Console.WriteLine("Associação de filme e gênero deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Associação não encontrada.");
            }
        }
    }
}
