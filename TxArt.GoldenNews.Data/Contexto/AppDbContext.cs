using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.EntityConfig;

namespace TxArt.GoldenNews.Data.Contexto
{
    public class AppDbContext:IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }

        #region:Entidades
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostsTags { get; set; }
        public DbSet<Reacao> Reacoes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TipoMedia> TiposMedias { get; set; }
        public DbSet<TipoReacao> TiposReacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        #region: Configurações Adicionais de Entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<string>>()
               .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(r => new { r.UserId, r.RoleId });

            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });


            //-------- Model Configurations --------//
            #region:Model Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoriaConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComentarioConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MediaConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReacaoConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TipoMediaConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TipoReacaoConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfig).Assembly);

            #endregion
        }
        #endregion
    }
}
