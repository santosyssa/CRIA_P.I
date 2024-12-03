using CRIA_WebApplication1.Domains;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.Repositories;
using CRIA_WebApplication1.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CRIA_WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class LoginController : Controller
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult BuscarPorEmailSenha(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = UsuarioRepository.BuscarPorEmaileSenha(login);
                if (usuarioBuscado == null)
                    return NotFound(new { mensagem = "Não foi possível encontrar o usuário!" });

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUser.ToString()),
                    new Claim("username",usuarioBuscado.Nome),
                    new Claim("tipo",usuarioBuscado.AcessoNavigation.nome),
                    new Claim(ClaimTypes.Role, usuarioBuscado.AcessoNavigation.nome),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("cria-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "CRIA.WebApi",
                    audience: "CRIA.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }
    }
}
