﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.EntityConfig
{
    public class TipoMediaConfig : IEntityTypeConfiguration<TipoMedia>
    {
        public void Configure(EntityTypeBuilder<TipoMedia> builder)
        {
            builder.ToTable("TipoMedia");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(250)");
        }
    }
}
