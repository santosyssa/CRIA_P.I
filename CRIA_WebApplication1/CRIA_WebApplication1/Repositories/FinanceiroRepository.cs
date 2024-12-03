using CRIA_WebApplication1.Contexts;
using CRIA_WebApplication1.Domains;
using CRIA_WebApplication1.Interfaces;

namespace CRIA_WebApplication1.Repositories
{
    public class FinanceiroRepository : IFinanceiroRepository
    {
        CRIAContext ctx = new CRIAContext();

       public List<Financeiro> ListarFinanceiro()
        {
            return ctx.Financeiros.ToList();
        }
    }
}
