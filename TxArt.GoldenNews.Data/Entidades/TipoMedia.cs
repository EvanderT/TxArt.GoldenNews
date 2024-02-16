using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class TipoMedia : BaseEntity
    {
        public string Nome { get; set; }
        public List<Media> Medias { get; set; }
    }
}
