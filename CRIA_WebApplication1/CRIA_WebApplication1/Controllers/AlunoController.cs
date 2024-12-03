using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class AlunoController : Controller
    {
        private IAlunoRepository AlunoRepository { get; set; }

        public AlunoController()
        {
            AlunoRepository = new AlunoRepository();
        }

        [HttpGet("ListarAluno")]
        public IActionResult ListarAluno()
        {
            return Ok(AlunoRepository.ListarAluno());
        }

    }
}
