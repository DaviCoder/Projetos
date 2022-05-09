using Avaliacao3.Business.Interface;
using Avaliacao3.Model;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao3.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class BaseController<T, V> : ControllerBase
        where T : Base_MD, new()
        where V : IBase_Business<T>
    {
        protected V _business;
        public BaseController(V business)
        {
            _business = business;
        }
        [HttpPost]
        public IActionResult Post([FromBody] T entity)
        {
            try
            {
                _business.Criar(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] T entity)
        {
            try
            {
                _business.Atualizar(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            try
            {
                _business.Deletar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        public virtual IActionResult Get()
        {
            try
            {
                return Ok(_business.BuscarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("id")]
        public virtual IActionResult Get(int id)
        {
            try
            {
                return Ok(_business.Buscar(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }

}
