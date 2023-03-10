using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;
using Microsoft.AspNetCore.Mvc;
namespace challenge_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _service;
        public PersonaController(IPersonaService service) { 
            _service = service;
        }

        [HttpGet]
        [Route("GetPersonas")]
        public async Task<IActionResult> GetPersonas()
        {
            try
            {
                return Ok(_service.GetPersonas());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
