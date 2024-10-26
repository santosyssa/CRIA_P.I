using CRIA_WebApplication1.Domains;

namespace CRIA_WebApplication1.Interfaces
{
    public interface IUsuarioRepository 
    {
        List<Usuario> Listar();

        void Cadastrar(Usuario usuario);
    }
}
