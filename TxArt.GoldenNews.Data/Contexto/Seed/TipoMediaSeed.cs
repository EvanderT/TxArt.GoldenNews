using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.Contexto.Seed
{
    public class TipoMediaSeed
    {
        public static async Task SeedData(AppDbContext context)
        {
            string[] nomes = {
                "Imagem",
                "Video",
                "Audio",
            };


            foreach (var nome in nomes)
            {
                if (!context.TiposMedias.Any(d => d.Nome == nome))
                {
                    var model = new TipoMedia { Nome = nome };
                    context.TiposMedias.Add(model);
                    context.SaveChanges();
                }
            }
        }
    }
}
