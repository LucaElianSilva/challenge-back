using challenge_back.Entities;
using challenge_back.Models;
using Microsoft.AspNetCore.Mvc;
namespace challenge_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ChallengeContext _dbContext;
        public ProductoController(ChallengeContext dbContext) { 
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetProductos")]
        public async Task<IActionResult> GetProductos()
        {
            try
            {
                List<Producto> productos = _dbContext.Productos.ToList();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
