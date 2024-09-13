using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Atores> Atores{ get; set; }
        public DbSet<Filmes> Filmes{ get; set; }
        public DbSet<ElencoFilmes> ElencoFilmes{ get; set; }
        public DbSet<FilmesGenero> ElencoGenero{ get; set; }
        public DbSet<Genero> Genero{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Inicial Catalog=SiteDeFilmes;Integrated Security=true");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Atores>(a => {
            a.ToTable("Atores"); //Nome da tabela
            a.HasKey(a => a.Id);  //chave primaria
            a.Property(a => a.PrimeiroNome);
            a.Property(a => a.UltimoNome);
            a.Property(a => a.Genero);
            
            a.HasMany(a => a.ElencoFilmes)
            .WithOne(x => x.Ator)
            .HasForeignKey(x => x.IdAtor);
        } );
        modelBuilder.Entity<Filmes>(f => {
            f.ToTable("Filmes");
            f.Haskey(f => f.Id);
            f.Property(f => f.Nome);
            f.Property(f => f.Ano);
            f.Property(f => f.duracao);
                  
            f.HasMany(f => f.ElencoFilmes)
            .WithOne(x => x.Filmes)
            .HasForeignKey(x => x.IdFilmes);
        } );
        modelBuilder.Entity<Generos>(g => {
            g.ToTable("Genero");
            g.Haskey(g => g.Id);
            g.Property(g => g.Genero);
                  
            g.HasMany(g => g.FilmesGenero)
            .WithOne(x => x.Genero)
            .HasForeignKey(x => x.IdGenero);
        } );
        modelBuilder.Entity<ElencoFilme>(e => {
            e.ToTable("ElencoFilme");
            e.Haskey(e => e.Id);
                  
            e.HasMany(e => e.Ator)
            .WithOne(x => x.ElencoFilmes)
            .HasForeignKey(x => x.IdAtor);
            
            e.HasMany(e =>:e.Filmes)
            .WithOne(x => x.ElencoFilme)
            .HasForeignKey(x => x.IdFilmes);
          
            
        } );
        modelBuilder.Entity<FilmesGenero>(g => {
            g.ToTable("FilmesGenero");
            g.Haskey(g => g.Id);
                  
            g.HasOne(g => g.FilmesGenero)
            .WithOne(e => e.Genero)
            .HasForeignKey(e => e.IdGenero);
        } );

    }

    }
}