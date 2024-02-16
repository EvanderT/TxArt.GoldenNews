using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class ComentarioRepository : BaseRepository<Comentario>, IComentarioRepository
    {
        public ComentarioRepository(AppDbContext db) : base(db)
        {
        }

        public Comentario BuscarPorId(string id)
        {
            return _db.Comentarios.FirstOrDefault(u => u.Id == id);
        }

    }
}
