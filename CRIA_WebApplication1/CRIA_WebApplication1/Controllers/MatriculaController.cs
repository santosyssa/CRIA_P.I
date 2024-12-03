using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class MatriculaController : Controller
    {
        private IMatriculaRepository MatriculaRepository { get; set; }

        public MatriculaController()
        {
            MatriculaRepository = new MatriculaRepository();
        }

        [HttpGet("ListarMatricula")]
        public IActionResult ListarMatricula()
        {
            return Ok(MatriculaRepository.ListarMatricula());
        }

    }
}
