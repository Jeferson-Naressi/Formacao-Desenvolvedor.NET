using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data.Configuration
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Generos>
    {
        public void Configure(EntityTypeBuilder<Generos> builder)
        {
                builder.ToTable("Generos");
                builder.HasKey(g => g.Id);
                builder.Property(g => g.Genero).HasColumnType("VARCHAR(20)");

                builder.HasMany(g => g.FilmesGeneros)
                .WithOne(fg => fg.Genero)
                .HasForeignKey(fg => fg.IdGenero);

        }
    }
    
}