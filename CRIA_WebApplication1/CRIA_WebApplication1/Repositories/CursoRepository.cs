using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Curso> Listar()
        {
           
            return ctx.Cursos.Include(x => x.ApiFams).ToList();
        }

    }
}
