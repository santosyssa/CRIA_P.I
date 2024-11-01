using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class ApiFamRepository : IApiFamRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<ApiFam> ListarApiFam()
        {
            return ctx.ApiFams.Include(x => x.IdCursoNavigation).Include(x => x.IdMentorNavigation).
                Include(x => x.RaNavigation).Include(x => x.ValidarMatriculaNavigation).ToList();

        }
    }
}
