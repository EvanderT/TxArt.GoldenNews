using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(AppDbContext db) : base(db)
        {
        }

        public Media BuscarPorId(string id)
        {
            return _db.Medias.FirstOrDefault(u => u.Id == id);
        }

    }
}
