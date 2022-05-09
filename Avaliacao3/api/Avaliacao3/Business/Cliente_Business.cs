using Avaliacao3.Business.Interface;
using Avaliacao3.DB;
using Avaliacao3.Model;

namespace Avaliacao3.Business
{
    public class Cliente_Business : Base_Business<Cliente_MD>, ICliente_Business
    {
        public static SqlEntityRepository<Cliente_MD> sqlServerRepository;
        public Cliente_Business(IRepository<Cliente_MD> repository) : base(repository)
        {
            sqlServerRepository = (SqlEntityRepository<Cliente_MD>)repository;
        }
    }
}
