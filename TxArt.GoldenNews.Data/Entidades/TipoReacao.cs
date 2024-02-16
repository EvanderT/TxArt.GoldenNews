using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class TipoReacao : BaseEntity
    {
        public string Nome { get; set; }
        public List<Reacao> Reacoes { get; set; } = new List<Reacao>();
    }
}
