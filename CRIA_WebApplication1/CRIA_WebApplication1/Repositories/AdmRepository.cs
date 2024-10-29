using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class AdmRepository : IAdmRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Adm> Listar()
        {
            return ctx.Adms.ToList();
        }
    }
}
