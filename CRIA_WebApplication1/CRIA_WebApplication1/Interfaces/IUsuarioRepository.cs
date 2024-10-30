using CRIA_WebApplication1.Domains;

namespace CRIA_WebApplication1.Interfaces
{
    public interface IUsuarioRepository 
    {
        List<Usuario> ListarUsuario();

        void Cadastrar(Usuario usuario);
    }
}
