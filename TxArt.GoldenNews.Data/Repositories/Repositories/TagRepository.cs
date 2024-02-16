using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext db) : base(db)
        {
        }

        public Tag BuscarPorId(string id)
        {
            return _db.Tags.FirstOrDefault(u => u.Id == id);
        }

    }
}
