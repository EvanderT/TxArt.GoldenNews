using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.Contexto.Seed
{
    public class TipoReacaoSeed
    {
        public static async Task SeedData(AppDbContext context)
        {
            string[] nomes = {
                "Estrela",
            };


            foreach (var nome in nomes)
            {
                if (!context.TiposReacoes.Any(d => d.Nome == nome))
                {
                    var model = new TipoReacao { Nome = nome };
                    context.TiposReacoes.Add(model);
                    context.SaveChanges();
                }
            }
        }
    }
}
