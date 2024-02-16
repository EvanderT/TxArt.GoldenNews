using Microsoft.EntityFrameworkCore;
using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext db) : base(db)
        {
        }

        public Usuario BuscarPorId(string id)
        {
            return _db.Usuarios.FirstOrDefault(u => u.Id == id);      
        }

        public Usuario BuscarPorNome(string nome)
        {
            return _db.Usuarios.FirstOrDefault(u => u.UserName == nome);
        }
    }
}
