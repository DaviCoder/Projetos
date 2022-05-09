using Avaliacao3.Business.Interface;
using Avaliacao3.Model;
using System.Linq.Expressions;

namespace Avaliacao3.DB
{
    public class SqlEntityRepository<T> : IRepository<T> where T : Base_MD, new()
    {
        public static Context Context = null;

        public SqlEntityRepository()
        {
            if (Context == null)
                Context = new Context();
        }

        public T Criar(T obj)
        {
            if (obj is null)
                throw new ArgumentNullException(nameof(obj));

            var entity = Context.Set<T>().Add(obj).Entity;
            Context.SaveChanges();
            return entity;
        }
        public T Atualizar(T obj)
        {
            if (obj is null)
                throw new ArgumentNullException(nameof(obj));
            Context.Set<T>().Update(obj);
            //Context.Entry<T>(obj).State = EntityState.Detached;
            Context.SaveChanges();
            return obj;
        }

        public T Buscar(int id)
        {
            var entity = Context.Set<T>().Find(id);
            if (entity is null)
                throw new Exception("Registro não encontrado");

            return entity;
        }

        public IEnumerable<T> BuscarTodos()
        {
            return Context.Set<T>().ToList();
        }

        public T Deletar(int id)
        {
            var obj = Context.Set<T>().Find(id);
            if (obj is not null)
            {
                var entity = Context.Set<T>().Remove(obj).Entity;
                Context.SaveChanges();
                return entity;

            }
            throw new Exception("Registro não encontrado");
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> where = null)
        {
            var obj = Context.Set<T>().Where(where).ToList();
            if (!obj.Any())
                throw new Exception("Expressão não retornou nada!");
            return obj;
        }

        public IEnumerable<T> QuerySqlRaw(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
