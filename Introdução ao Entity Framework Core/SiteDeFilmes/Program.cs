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
            AdicionarAtores(new List<Atores>
            {
                new Atores { PrimeiroNome = "James", UltimoNome = "Stewart", Genero = "M"},
                new Atores { PrimeiroNome = "Deborah", UltimoNome = "Kerr", Genero = "F" },
                new Atores { PrimeiroNome = "Peter", UltimoNome = "O'Toole", Genero = "M" },
                new Atores { PrimeiroNome = "Robert",UltimoNome ="DeNiro", Genero = "M" },
                new Atores { PrimeiroNome = "Harrison", UltimoNome = "Ford", Genero = "M" },
                new Atores { PrimeiroNome = "Stephen", UltimoNome = "Baldwin", Genero = "M" },
                new Atores { PrimeiroNome = "Jack", UltimoNome = "Nicholson", Genero= "M" },
                new Atores { PrimeiroNome = "Mark", UltimoNome = "Wahlberg", Genero = "M" },
                new Atores { PrimeiroNome = "Woody", UltimoNome = "Allen", Genero = "M" },
                new Atores { PrimeiroNome = "Claire", UltimoNome = "Danes", Genero = "F" },
                new Atores { PrimeiroNome = "Tim", UltimoNome = "Robbins",Genero = "M" },
                new Atores { PrimeiroNome = "Kevin", UltimoNome = "Spacey", Genero = "M" },
                new Atores { PrimeiroNome = "Kate", UltimoNome = "Winslet",Genero ="F" },
//Robin Williams, M
//Jon Voight, M
//Ewan McGregor, M
//Christian Bale, M
//Maggie Gyllenhaal, F
//Dev Patel, M
//Sigourney Weaver, F
//David Aston, M
//Ali Astin, F

            });
            
            ////ConsultarAtores();

            AdicionarFilmes(new List<Filmes>
            {
                new Filmes { Nome = "Um Corpo que Cai", Ano = 1958, Duracao = 128 },
                new Filmes { Nome = "Os Inocentes", Ano = 1961, Duracao = 100 },
                new Filmes { Nome = "Lawrence da Arábia", Ano = 1962, Duracao = 216 },
                new Filmes { Nome = "O Franco Atirador", Ano = 1978, Duracao = 183 },
                new Filmes { Nome = "Amadeus", Ano = 1984, Duracao = 160 },
                new Filmes { Nome = "Blade Runner", Ano = 1982, Duracao = 117 },
                new Filmes { Nome = "De Olhos Bem Fechados", Ano = 1999, Duracao = 159 },
                new Filmes { Nome = "Os Suspeitos", Ano = 1995, Duracao = 106 },
                new Filmes { Nome = "Chinatown", Ano = 1974, Duracao = 130 },
                new Filmes { Nome = "Boogie Nights - Prazer Sem Limites", Ano = 1997, Duracao = 155 },
                new Filmes { Nome = "Noivo Neurótico, Noiva Nervosa", Ano = 1977, Duracao = 93 },
                new Filmes { Nome = "Princesa Mononoke", Ano = 1997, Duracao = 134 },
                new Filmes { Nome = "Um Sonho de Liberdade", Ano = 1994, Duracao = 142 },
                new Filmes { Nome = "Beleza Americana", Ano = 1999, Duracao = 122 },
                new Filmes { Nome = "Titanic", Ano = 1997, Duracao = 194 },
                new Filmes { Nome = "Gênio Indomável", Ano = 1997, Duracao = 126 },
                new Filmes { Nome = "Amargo pesadelo", Ano = 1972, Duracao = 109 },
                new Filmes { Nome = "Trainspotting - Sem Limites", Ano = 1976, Duracao = 94 },
                new Filmes { Nome = "O Grande Truque", Ano = 2006, Duracao = 130 },

//Donnie Darko, 2001, 113 min
//Quem Quer Ser um Milionário?, 2008, 120 min
//Aliens, O Resgate, 1986, 137 min
//Uma Vida sem Limites, 2004, 118 min
//Avatar, 2009, 162 min
//Coração Valente, 1995, 178 min
//Os Sete Samurais, 1954, 207 min
//A Viagem de Chihiro, 2001, 125 min
//De Volta para o Futuro, 1985, 116 min


            });
            //ConsultarFilmes();

            AdicionarGeneros(new List<Generos>
            {
                new Generos { Genero = "Ação" },
                new Generos { Genero = "Aventura" },
                new Generos { Genero = "Animação" },
                new Generos { Genero = "Biografia" },
                new Generos { Genero = "Comédia" },
                new Generos { Genero = "Crime" },
                new Generos { Genero = "Drama" },
                new Generos { Genero = "Horror" },
                new Generos { Genero = "Musical" },
                new Generos { Genero = "Mistério" },
                new Generos { Genero = "Romance" },
                new Generos { Genero = "Suspense" },
                new Generos { Genero = "Guerra" },

            });
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

            // Consultas após atualizações e exclusões
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
                Console.WriteLine($"Id:{filme.Id}, filme: {filme.Nome}, Ano: {filme.Ano}");
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
