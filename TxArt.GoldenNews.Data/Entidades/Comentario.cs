using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Comentario : BaseEntity
    {
        public string Descricao { get; set; } = string.Empty;
        public string PostId { get; set; } 
        public string UsuarioId { get; set; }

        public virtual Post Post { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
