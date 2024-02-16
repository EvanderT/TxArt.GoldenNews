using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.EntityConfig
{
    public class ReacaoConfig : IEntityTypeConfiguration<Reacao>
    {
        public void Configure(EntityTypeBuilder<Reacao> builder)
        {
            builder.ToTable("Reacao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Icone)
                .HasColumnType("varchar(550)");

            builder.HasOne(p => p.Post)
                .WithMany(p => p.Reacoes)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.TipoReacao)
                .WithMany(p => p.Reacoes)
                .HasForeignKey(p => p.TipoReacaoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.Reacoes)
                .HasForeignKey(p => p.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
