using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Mentor> ListarMentor()
        {
            return ctx.Mentors.Include(x => x.IdCursoNavigation).ToList();
        }
    }
}
