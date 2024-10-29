using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Matricula> Litar()
        {
            return ctx.Matriculas.ToList();
        }
    }
}
