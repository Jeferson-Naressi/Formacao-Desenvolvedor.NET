using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteDeFilmes.Models;

namespace SiteDeFilmes.Data.Configuration
{
    public class AtoresConfiguration : IEntityTypeConfiguration<Atores>
    {
        public void Configure(EntityTypeBuilder<Atores> builder)
        {
                builder.ToTable("Atores"); // Nome da tabela
                builder.HasKey(a => a.Id); // Chave primária
                builder.Property(a => a.PrimeiroNome).HasColumnType("VARCHAR(20)");
                builder.Property(a => a.UltimoNome).HasColumnType("VARCHAR(20)");
                builder.Property(a => a.Genero).HasColumnType("VARCHAR(1)");

                builder.HasMany(a => a.ElencoFilmes) // Relação um para muitos
                .WithOne(e => e.Atores) // Relação muitos para um
                .HasForeignKey(e => e.IdAtor); // Chave estrangeira
        }
    }
    
}