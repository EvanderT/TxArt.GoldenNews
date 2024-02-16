using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Entidades
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            DataCadastro = DateTime.Now;
            Activo = true;
        }

        public string Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Activo { get; set; }
    }
}
