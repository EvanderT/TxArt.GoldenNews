using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.Contexto.Seed
{
    public class TagSeed
    {
        public static async Task SeedData(AppDbContext context)
        {
            string[] nomes = {
                "Smarthphones",
                "Ciclismo",
                "Filmes",
                "Séries",
                "Animes",
                "Carros",
            };


            foreach (var nome in nomes)
            {
                if (!context.Tags.Any(d => d.Nome == nome))
                {
                    var model = new Tag { Nome = nome };
                    context.Tags.Add(model);
                    context.SaveChanges();
                }
            }
        }
    }
}
