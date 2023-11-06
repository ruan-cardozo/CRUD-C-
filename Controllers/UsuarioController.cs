using Microsoft.AspNetCore.Mvc;
using SistemaDeVeiculos.Models;

namespace SistemaDeVeiculos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> buscarTodosUsuarios()
        {
            return Ok();
        }
    }

}
