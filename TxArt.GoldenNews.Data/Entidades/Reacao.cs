using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Reacao : BaseEntity
    {
        public string Nome { get; set; }
        public string Icone { get; set; }
        public string UsuarioId { get; set; }
        public string PostId { get; set; }
        public string TipoReacaoId { get; set; }
        public Usuario Usuario { get; set; }
        public Post Post { get; set; }
        public TipoReacao TipoReacao { get; set; }
    }
}
