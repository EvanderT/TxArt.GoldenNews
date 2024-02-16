using Microsoft.EntityFrameworkCore;
using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Repositories.Interfaces;

namespace TxArt.GoldenNews.Data.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly AppDbContext _db;

        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Adicionar(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges();
        }

        public TEntity BuscarPorId(string id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public ICollection<TEntity> BuscarTodos()
        {
            return _db.Set<TEntity>().ToList();
        }

        public ICollection<TEntity> BuscarTodosSemMapeamento()
        {
            return _db.Set<TEntity>().AsNoTracking().ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Editar(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Excluir(TEntity entity)
        {
            //Verificar se a entidade possui uma propriedade de nome ativo.
            var ativoProp = entity.GetType().GetProperty("Activo");
            if (ativoProp != null)
            {
                //Definir novo valor da propriedade
                ativoProp.SetValue(entity, false);
                _db.Set<TEntity>().Update(entity);
                _db.SaveChanges();
            }
            else
            {
                // Lança uma exceção ou realiza outra ação, caso a propriedade não seja encontrada
                throw new InvalidOperationException("A entidade não possui a propriedade 'Ativo'.");
            }
        }
    }
}
