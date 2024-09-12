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
        public DbSet<FilmeGenero> ElencoGenero{ get; set; }
        public DbSet<Genero> Genero{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Inicial Catalog=SiteDeFilmes;Integrated Security=true");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Atores>(a => {
            a.ToTable("Atores"); //Nome da tabeaa
            a.HasKey(a => a.Id);  //chave primaria
            a.Property(a => a.PrimeiroNome);
            a.Property(a => a.UltimoNome);
            a.Property(a => a.Genero);
            
            a.HasMany(a => a.ElencoFilmes)
            .WithOne(e => e.Ator)
            .HasForeignKey(e => e.IdAtor); //Chave secundaria
        } );
    }

    }
}