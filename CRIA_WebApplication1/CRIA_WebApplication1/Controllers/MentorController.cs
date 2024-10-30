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

    public class MentorController : Controller
    {
        private IMentorRepository  MentorRepository { get; set; }

        public MentorController()
        {
            MentorRepository = new MentorRepository();
        }

        // GET
        [HttpGet("ListarMentor")]
        public IActionResult ListarMentor()
        {
            return Ok(MentorRepository.ListarMentor());
        }
    }
 }

