using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxArt.GoldenNews.Data.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public ICollection<TEntity> BuscarTodos();
        public ICollection<TEntity> BuscarTodosSemMapeamento();
        public TEntity BuscarPorId(string id);
        public void Adicionar(TEntity entity);
        public void Editar(TEntity entity);

        public void Excluir(TEntity entity);
    }
}
