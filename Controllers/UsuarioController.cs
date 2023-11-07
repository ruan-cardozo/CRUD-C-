using Microsoft.AspNetCore.Mvc;
using SistemaDeVeiculos.Models;
using SistemaDeVeiculos.Repositorios.Interfaces;


namespace SistemaDeVeiculos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
            }
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Adicionar(UsuarioModel usuario)
        {
            UsuarioModel usuarioAdicionado = await _usuarioRepositorio.Adicionar(usuario);
            return Ok(usuarioAdicionado);
        }

    }


}
