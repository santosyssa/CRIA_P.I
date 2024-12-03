using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.ViewsModels;

namespace CRIA_WebApplication1.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarPorEmaileSenha(LoginViewModel login);
    }
}
