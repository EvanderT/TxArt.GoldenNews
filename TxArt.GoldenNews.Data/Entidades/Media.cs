using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Media : BaseEntity
    {
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public int TamanhoBits { get; set; }
        public string PostId { get; set; }
        public string TipoMediaId { get; set; }

        public virtual Post Post { get; set; }
        public virtual TipoMedia TipoMedia { get; set; }
    }
}
