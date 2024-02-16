using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class ReacaoRepository : BaseRepository<Reacao>, IReacaoRepository
    {
        public ReacaoRepository(AppDbContext db) : base(db)
        {
        }

        public Reacao BuscarPorId(string id)
        {
            return _db.Reacoes.FirstOrDefault(u => u.Id == id);
        }

    }
}
