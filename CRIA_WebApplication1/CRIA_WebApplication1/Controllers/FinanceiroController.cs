using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRIA_WebApplication1.Controllers
{ 
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class FinanceiroController : Controller
    {

        private IFinanceiroRepository FinanceiroRepository { get; set; }

        public FinanceiroController()
        {
            FinanceiroRepository = new FinanceiroRepository();
        }

        [HttpGet("ListarFinanceiro")]
        public IActionResult ListarFinanceiro()
        {
            return Ok(FinanceiroRepository.ListarFinanceiro());
        }

    }
}
