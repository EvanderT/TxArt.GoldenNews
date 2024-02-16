using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class TipoReacaoRepository : BaseRepository<TipoReacao>, ITipoReacaoRepository
    {
        public TipoReacaoRepository(AppDbContext db) : base(db)
        {
        }

        public TipoReacao BuscarPorId(string id)
        {
            return _db.TiposReacoes.FirstOrDefault(u => u.Id == id);
        }

    }
}
