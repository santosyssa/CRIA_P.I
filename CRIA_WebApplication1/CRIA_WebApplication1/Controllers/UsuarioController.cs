using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuarioController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        // GET
        [HttpGet("ListarUsuario")]
        public IActionResult ListarUsuario()
        {
            return Ok(UsuarioRepository.ListarUsuario());
        }
    }
}
