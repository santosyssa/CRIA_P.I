using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using CRIA_WebApplication1.ViewsModels;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        CRIAContext ctx = new CRIAContext();

        public Usuario BuscarPorEmaileSenha(LoginViewModel login)
        {
            Usuario usuario = ctx.Usuarios.Include(x => x.AcessoNavigation).FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);
            if (usuario == null)
                return null;
            return usuario;
        }
    }
}
