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
        public DbSet<ElencoFilme> ElencoFilmes{ get; set; }
        public DbSet<FilmesGenero> FilmesGeneros{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Inicial Catalog=SiteDeFilmes;Integrated Security=true");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<FilmesGenero>(p => {
            p.ToTable("ElencoGenero"); //Nome da tablema
            p.HasKey(p => p.Id);  //chave primaria
            p.Property(p => p.IdGenero);  
        } );
    }

    }
}