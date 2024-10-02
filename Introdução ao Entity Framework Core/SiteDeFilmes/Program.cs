using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SiteDeFilmes.Data;
using SiteDeFilmes.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SiteDeFilmes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplos de uso
            //AdicionarAtores(new List<Atores>
            //{
            //    new Atores { PrimeiroNome = "Robin", UltimoNome = "Williams", Genero = "M"},
            //    new Atores { PrimeiroNome = "Jon", UltimoNome = "Voight", Genero = "M" },
            //    new Atores { PrimeiroNome = "Ewan", UltimoNome = "O'McGregor", Genero = "M" },
            //    new Atores { PrimeiroNome = "Christian",UltimoNome ="Bale", Genero = "F" },
            //    new Atores { PrimeiroNome = "Maggie",UltimoNome ="Gyllenhaal", Genero = "M" },
            //    new Atores { PrimeiroNome = "Dev",UltimoNome ="Patel", Genero = "M" },
            //    new Atores { PrimeiroNome = "Sigourney",UltimoNome ="Weaver", Genero = "F" },
            //    new Atores { PrimeiroNome = "David",UltimoNome ="Aston", Genero = "M" },
            //    new Atores { PrimeiroNome = "Ali",UltimoNome ="Astin", Genero = "F" },

            //});
            
            ////ConsultarAtores();

            //AdicionarFilmes(new List<Filmes>
            //{
            //    new Filmes { Nome = "Donnie Darko", Ano = 2001, Duracao = 113 },
            //    new Filmes { Nome = "Quem Quer Ser um Milionário?", Ano = 2001, Duracao = 120 },
            //    new Filmes { Nome = "Aliens, O Resgate", Ano = 1986, Duracao = 137 },
            //    new Filmes { Nome = "Uma Vida sem Limites", Ano = 2009, Duracao = 162 },
            //    new Filmes { Nome = "Os Sete Samurais", Ano = 1954, Duracao = 207 },
            //    new Filmes { Nome = "A Viagem de Chihiro", Ano = 2001, Duracao = 125 },
            //    new Filmes { Nome = "De Volta para o Futuro", Ano = 1985, Duracao = 116 },
            //});

            //ConsultarFilmes();

            //AdicionarAtores();
            //AdicionarElencos();
            //AdicionarGeneros();
            

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

            // Consultas 
            ConsultarAtores();
            ConsultarFilmes();
            ConsultarGeneros();
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
                Console.WriteLine($"Id:{ator.Id}, Nome: {ator.PrimeiroNome} {ator.UltimoNome}");
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
                Console.WriteLine($"Id:{filme.Id}, filme: {filme.Nome}, Ano: {filme.Ano}, Duração: {filme.Duracao} mins");
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
                Console.WriteLine($"Id:{gen.Id}, Gênero: {gen.Genero}");
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
                Console.WriteLine($"Id:{item.Id}, Ator ID: {item.IdAtor}, Filme ID: {item.IdFilmes}, Papel: {item.Papel}");
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
                Console.WriteLine($"ID:{item.Id}, Filme ID: {item.IdFilmes}, Gênero ID: {item.IdGenero}");
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
