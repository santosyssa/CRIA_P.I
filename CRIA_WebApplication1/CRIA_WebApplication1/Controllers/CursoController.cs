using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class CursoController : Controller
    {
        private ICursoRepository CursoRepository { get; set; }

        public CursoController()
        {
            CursoRepository = new CursoRepository();
        }

        [HttpGet("ListarCurso")]
        public IActionResult ListarCurso()
        {
            return Ok(CursoRepository.ListarCurso());
        }
    }
}
