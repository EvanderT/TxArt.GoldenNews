using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Tag : BaseEntity
    {
        public string Nome { get; set; }
        public virtual List<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
