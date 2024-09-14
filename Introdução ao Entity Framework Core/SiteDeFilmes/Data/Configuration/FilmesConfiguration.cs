using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data.Configuration
{
    public class FilmesConfiguration : IEntityTypeConfiguration<Filmes>
    {
        public void Configure(EntityTypeBuilder<Filmes> builder)
        {
                builder.ToTable("Filmes");
                builder.HasKey(f => f.Id);
                builder.Property(f => f.Nome);
                builder.Property(f => f.Ano);
                builder.Property(f => f.Duracao);

                builder.HasMany(f => f.ElencoFilmes)
                .WithOne(e => e.Filme)
                .HasForeignKey(e => e.IdFilmes);
                
                builder.HasMany(f => f.FilmesGeneros)
                .WithOne(fg => fg.Filme)
                .HasForeignKey(fg => fg.IdFilmes);

        }
    }
    
}