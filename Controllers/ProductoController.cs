using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;
using Microsoft.AspNetCore.Mvc;
namespace challenge_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;
        public ProductoController(IProductoService service) { 
            _service = service;
        }

        [HttpGet]
        [Route("GetProductos")]
        public async Task<IActionResult> GetProductos()
        {
            try
            {
                return Ok(_service.GetProductos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
