using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Post : BaseEntity
    {
        public string FotoCapaUrl { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public string CategoriaId { get; set; }
        public string UsuarioId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Comentario> Comentarios { get; set; }
        public virtual List<PostTag> PostTags { get; set; }
        public virtual List<Reacao> Reacoes { get; set; }
        public virtual List<Media> Medias { get; set; }
    }
}
