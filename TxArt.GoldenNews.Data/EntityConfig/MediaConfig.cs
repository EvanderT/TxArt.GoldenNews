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
    public class MediaConfig : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("Media");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(550)");

            builder.Property(p => p.Caminho)
                .HasColumnType("varchar(550)");

            builder.HasOne(p => p.Post)
                .WithMany(p => p.Medias)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.TipoMedia)
                .WithMany(p => p.Medias)
                .HasForeignKey(p => p.TipoMediaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
