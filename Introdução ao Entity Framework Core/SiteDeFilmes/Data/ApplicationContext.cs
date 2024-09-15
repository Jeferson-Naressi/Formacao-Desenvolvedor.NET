using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteDeFilmes.Data.Configuration;
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
            modelBuilder.ApplyConfiguration(new AtoresConfiguration());
            modelBuilder.ApplyConfiguration(new ElencoFilmesConfiguration());
            modelBuilder.ApplyConfiguration(new FilmesConfiguration());
            modelBuilder.ApplyConfiguration(new FilmesGenerosConfiguration());
            modelBuilder.ApplyConfiguration(new GenerosConfiguration());

        }
        
    }
}
