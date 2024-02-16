using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class TipoMediaRepository : BaseRepository<TipoMedia>, ITipoMediaRepository
    {
        public TipoMediaRepository(AppDbContext db) : base(db)
        {
        }

        public TipoMedia BuscarPorId(string id)
        {
            return _db.TiposMedias.FirstOrDefault(u => u.Id == id);
        }

    }
}
