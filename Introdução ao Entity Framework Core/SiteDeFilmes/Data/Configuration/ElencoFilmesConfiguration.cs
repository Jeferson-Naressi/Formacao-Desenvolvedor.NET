using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data.Configuration
{
    public class ElencoFilmesConfiguration : IEntityTypeConfiguration<ElencoFilmes>
    {
        public void Configure(EntityTypeBuilder<ElencoFilmes> builder)
        {
                builder.ToTable("ElencoFilmes");
                builder.HasKey(e => e.Id);
                builder.Property(e => e.IdAtor).HasConversion<int>();
                builder.Property(e => e.IdFilmes).HasConversion<int>();
                builder.Property(e => e.Papel).HasColumnType("VARCHAR(30)").IsRequired(false);


                builder.HasOne(e => e.Atores)
                .WithMany(a => a.ElencoFilmes)
                .HasForeignKey(e => e.IdAtor);
                
                builder.HasOne(e => e.Filme)
                .WithMany(f => f.ElencoFilmes)
                .HasForeignKey(e => e.IdFilmes);

        }
    }
    
}










