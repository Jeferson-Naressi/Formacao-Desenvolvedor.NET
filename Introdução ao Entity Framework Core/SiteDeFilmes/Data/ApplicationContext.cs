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
        public DbSet<Atores> Atores { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<ElencoFilmes> ElencoFilmes { get; set; }
        public DbSet<FilmesGeneros> FilmesGeneros { get; set; }
        public DbSet<Generos> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=SiteDeFilmes;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atores>(a =>
            {
                a.ToTable("Atores"); // Nome da tabela
                a.HasKey(a => a.Id); // Chave primária
                a.Property(a => a.PrimeiroNome).HasColumnType("VARCHAR(20)").IsRequired();
                a.Property(a => a.UltimoNome).HasColumnType("VARCHAR(20)");;
                a.Property(a => a.Genero).HasColumnType("VARCHAR(1)");

                a.HasMany(a => a.ElencoFilmes) // Relação um para muitos
                .WithOne(e => e.Atores) // Relação muitos para um
                .HasForeignKey(e => e.IdAtor); // Chave estrangeira
            });

            modelBuilder.Entity<Filmes>(f =>
            {
                f.ToTable("Filmes");
                f.HasKey(f => f.Id);
                f.Property(f => f.Nome);
                f.Property(f => f.Ano);
                f.Property(f => f.Duracao);

                f.HasMany(f => f.ElencoFilmes)
                .WithOne(e => e.Filme)
                .HasForeignKey(e => e.IdFilmes);
                
                f.HasMany(f => f.FilmesGeneros)
                .WithOne(fg => fg.Filme)
                .HasForeignKey(fg => fg.IdFilmes);
            });

            modelBuilder.Entity<Generos>(g =>
            {
                g.ToTable("Generos");
                g.HasKey(g => g.Id);
                g.Property(g => g.Genero);

                g.HasMany(g => g.FilmesGeneros)
                .WithOne(fg => fg.Genero)
                .HasForeignKey(fg => fg.IdGenero);
            });

            modelBuilder.Entity<ElencoFilmes>(e =>
            {
                e.ToTable("ElencoFilmes");
                e.HasKey(e => e.Id);
                e.Property(e => e.Papel);

                e.HasOne(e => e.Atores)
                .WithMany(a => a.ElencoFilmes)
                .HasForeignKey(e => e.IdAtor).IsRequired();
                
                e.HasOne(e => e.Filme)
                .WithMany(f => f.ElencoFilmes)
                .HasForeignKey(e => e.IdFilmes);
            });

            modelBuilder.Entity<FilmesGeneros>(fg =>
            {
                fg.ToTable("FilmesGeneros");
                fg.HasKey(fg => fg.Id);

                fg.HasOne(fg => fg.Genero)
                .WithMany(g => g.FilmesGeneros)
                .HasForeignKey(fg => fg.IdGenero);
                
                fg.HasOne(fg => fg.Filme)
                .WithMany(f => f.FilmesGeneros)
                .HasForeignKey(fg => fg.IdFilmes);
            });
        }
    }
}
