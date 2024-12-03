using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRIA_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class InscricaoController : Controller
    {
        private IInscricaoRepository InscricaoRepository { get; set; }

        public InscricaoController()
        {
            InscricaoRepository = new InscricaoRepository();
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet("ListarInscricao")]
        public IActionResult ListarInscricao()
        {
            return Ok(InscricaoRepository.ListarInscricao());
        }

        [HttpPost]
        public IActionResult Cadastrar(Inscricao inscricao)
        {
            try
            {
                InscricaoRepository.Cadastrar(inscricao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

    }
}
