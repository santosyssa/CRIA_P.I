using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;

namespace CRIA_WebApplication1.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Curso> ListarCurso()
        {
            return ctx.Cursos.ToList();
        }

    }
}
