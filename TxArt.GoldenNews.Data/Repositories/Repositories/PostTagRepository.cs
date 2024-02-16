using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class PostTagRepository : BaseRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(AppDbContext db) : base(db)
        {
        }

        public PostTag BuscarPorId(string id)
        {
            return _db.PostsTags.FirstOrDefault(u => u.Id == id);
        }

    }
}
