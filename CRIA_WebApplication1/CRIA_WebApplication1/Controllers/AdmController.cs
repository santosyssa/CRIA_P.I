using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AdmController : ControllerBase
    {
        private IAdmRepository AdmRepository { get; set; }

        public AdmController()
        {
            AdmRepository = new AdmRepository();
        }

        [HttpGet("ListarAdm")]
        public IActionResult ListarAdm()
        {
            return Ok(AdmRepository.ListarAdm());
        }
    }
}
