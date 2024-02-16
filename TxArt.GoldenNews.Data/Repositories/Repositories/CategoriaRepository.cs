using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext db) : base(db)
        {
        }

        public Categoria BuscarPorId(string id)
        {
            return _db.Categorias.FirstOrDefault(u => u.Id == id);
        }

    }
}
