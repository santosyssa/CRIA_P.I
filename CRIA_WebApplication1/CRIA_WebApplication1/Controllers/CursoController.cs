using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Http;
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

        // GET: HomeController
        [HttpGet]
        public IEnumerable<Curso> Listar()
        {
            return CursoRepository.Listar();
        }

    }
}
