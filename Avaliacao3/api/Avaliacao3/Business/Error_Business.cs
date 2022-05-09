using Avaliacao3.Business.Interface;
using Avaliacao3.DB;
using Avaliacao3.Model;

namespace Avaliacao3.Business
{
    public class Error_Business : Base_Business<Error_MD>, IError_Business
    {
        public static SqlRawRepository<Error_MD> sqlRawRepository;
        
        public Error_Business(IRepository<Error_MD> repository) : base(repository)
        {
            sqlRawRepository = (SqlRawRepository<Error_MD>)repository;
        }

        public override IEnumerable<Error_MD> BuscarTodos()
        {
            return sqlRawRepository.QuerySqlRaw("SELECT * FROM errorLogs");
        }

        public override Error_MD Criar(Error_MD obj)
        {
            return sqlRawRepository.Criar(obj);
        }
    }
}
