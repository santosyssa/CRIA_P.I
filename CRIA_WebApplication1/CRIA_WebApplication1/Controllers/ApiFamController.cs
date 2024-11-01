using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ApiFamController : ControllerBase
    {
        private IApiFamRepository ApiFamRepository { get; set; }

        public ApiFamController()
        {
            ApiFamRepository = new ApiFamRepository();
        }

        [HttpGet("ListarApiFam")]
        public IActionResult ListarAdm()
        {
            return Ok(ApiFamRepository.ListarApiFam());
        }
    }
}
