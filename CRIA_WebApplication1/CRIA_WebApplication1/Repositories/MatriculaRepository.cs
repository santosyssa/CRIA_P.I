using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Matricula> ListarMatricula()
        {
            return ctx.Matriculas.Include(x => x.RaNavigation).Include(x => x.IdCursoNavigation).ToList();
        }
    }
}
