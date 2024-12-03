using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;

namespace CRIA_WebApplication1.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Aluno> ListarAluno()
        {
            return ctx.Alunos.ToList();
        }
    }
}
