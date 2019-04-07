using Microsoft.AspNetCore.Mvc;

namespace LojasAlternativas.QuickBuy.API.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }


        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

    }
}
