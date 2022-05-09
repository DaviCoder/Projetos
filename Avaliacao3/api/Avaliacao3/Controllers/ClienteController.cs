using Avaliacao3.Business;
using Avaliacao3.Business.Interface;
using Avaliacao3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao3.Controllers
{
    public class ClienteController : BaseController<Cliente_MD, ICliente_Business>
    {
        public ClienteController(ICliente_Business business) : base(business)
        {
        }
    }
}
