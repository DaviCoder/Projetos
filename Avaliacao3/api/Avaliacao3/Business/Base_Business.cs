using Avaliacao3.Business.Interface;
using Avaliacao3.DB;
using Avaliacao3.Model;

namespace Avaliacao3.Business
{
    public class Base_Business<T> : IBase_Business<T> where T : Base_MD, new()
    {
        
        protected IRepository<T> DA;

        public Base_Business(IRepository<T> repository)
        {
            DA = repository;
        }

        public virtual T Criar(T obj)
        {
            return DA.Criar(obj);
        }
        public virtual T Atualizar(T obj)
        {
            return DA.Atualizar(obj);
        }

        public virtual T Buscar(int id)
        {
            return DA.Buscar(id);
        }

        public virtual IEnumerable<T> BuscarTodos()
        {
            return DA.BuscarTodos();
        }

        public virtual T Deletar(int id)
        {
            return DA.Deletar(id);
        }
    }
}
