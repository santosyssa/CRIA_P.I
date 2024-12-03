using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Repositories
{
    public class InscricaoRepository : IInscricaoRepository
    {
        CRIAContext ctx = new CRIAContext();

        public List<Inscricao> ListarInscricao()
        {
            return ctx.Inscricaos.Include(x => x.FamNavigation).ToList();
        }

        public void Cadastrar(Inscricao inscricao)
        {
            ctx.Inscricaos.Add(inscricao);
            ctx.SaveChanges();
        }
    }
}
