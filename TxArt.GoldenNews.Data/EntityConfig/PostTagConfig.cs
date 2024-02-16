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
    public class PostTagConfig : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {

            builder.ToTable("PostTag");
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Tag)
                .WithMany(p => p.PostTags)
                .HasForeignKey(p => p.TagId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
