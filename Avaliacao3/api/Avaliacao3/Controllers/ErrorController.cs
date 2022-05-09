using Avaliacao3.Business.Interface;
using Avaliacao3.Model;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao3.Controllers
{
    public class ErrorController : BaseController<Error_MD, IError_Business>
    {
        public ErrorController(IError_Business business) : base(business)
        {
        }
    }
}
