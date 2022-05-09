using Avaliacao3.Model;
using System.Linq.Expressions;

namespace Avaliacao3.Business.Interface
{
    public interface IRepository<T> : IRepository where T : Base_MD, new()
    {
        T Criar(T obj);
        T Deletar(int id);
        T Atualizar(T obj);
        T Buscar(int id);
        IEnumerable<T> BuscarTodos();
        IEnumerable<T> Query(Expression<Func<T, bool>> where = null);
        IEnumerable<T> QuerySqlRaw(string sql);
    }

    public interface IRepository { }
}