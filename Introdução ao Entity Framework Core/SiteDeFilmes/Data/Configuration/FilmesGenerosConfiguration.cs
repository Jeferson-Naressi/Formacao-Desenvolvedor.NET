using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data.Configuration
{
    public class FilmesGenerosConfiguration : IEntityTypeConfiguration<FilmesGeneros>
    {
        public void Configure(EntityTypeBuilder<FilmesGeneros> builder)
        {
                builder.ToTable("FilmesGeneros");
                builder.HasKey(fg => fg.Id);
                builder.Property(fg => fg.IdGenero).HasConversion<int>();
                builder.Property(fg => fg.IdFilmes).HasConversion<int>();

                builder.HasOne(fg => fg.Genero)
                .WithMany(g => g.FilmesGeneros)
                .HasForeignKey(fg => fg.IdGenero);
                
                builder.HasOne(fg => fg.Filme)
                .WithMany(f => f.FilmesGeneros)
                .HasForeignKey(fg => fg.IdFilmes);

        }
    }
    
}