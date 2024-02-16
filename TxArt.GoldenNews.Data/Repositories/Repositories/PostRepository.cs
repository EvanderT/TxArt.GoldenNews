using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext db) : base(db)
        {
        }

        public Post BuscarPorId(string id)
        {
            return _db.Posts.FirstOrDefault(u => u.Id == id);
        }

    }
}
