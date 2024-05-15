using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        #region HTTP POST
        #endregion

        #region HTTP PACTH
        #endregion

        #region HTTP GET
        [HttpGet]
        public IActionResult GetTodasCategorias()
        {

            return Ok();
        }
        [HttpGet]
        [Route("{id: Guid}")]
        public IActionResult GetTodasCategoriasPorId(Guid id)
        {
            return BadRequest();
        }
        #endregion

    }
}