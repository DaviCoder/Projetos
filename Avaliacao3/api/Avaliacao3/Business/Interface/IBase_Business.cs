using Avaliacao3.Model;

namespace Avaliacao3.Business.Interface
{
    public interface IBase_Business<T> where T : Base_MD, new()
    {
        T Criar(T obj);
        T Deletar(int id);
        T Atualizar(T obj);
        T Buscar(int id);
        IEnumerable<T> BuscarTodos();
    }
}
