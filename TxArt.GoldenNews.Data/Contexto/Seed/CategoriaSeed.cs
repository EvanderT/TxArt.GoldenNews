using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.Contexto.Seed
{
    public class CategoriaSeed
    {
        public static async Task SeedData(AppDbContext context)
        {
            string[] nomes = {
                "Sem Categoria",
                "Tecnologia",
                "Programação",
                "Departamento de Tecnologia da Informação (TI)",
                "Anúncio",
                "Saúde",
                "Desporto",
                "Economia",
                "Entreternimento"
                
            };


            foreach (var nome in nomes)
            {
                if (!context.Categorias.Any(d => d.Nome == nome))
                {
                    var model = new Categoria { Nome = nome };
                    context.Categorias.Add(model);
                    context.SaveChanges();
                }
            }
        }
    }
}
