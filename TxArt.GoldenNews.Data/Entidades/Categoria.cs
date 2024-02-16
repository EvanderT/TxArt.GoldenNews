using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class Categoria : BaseEntity
    {
        public Categoria()
        {

        }

        public Categoria(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
