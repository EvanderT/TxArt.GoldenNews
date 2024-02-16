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
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Conteudo)
                .HasColumnType("text");

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.Posts)
                .HasForeignKey(p => p.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Posts)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
