using LojasAlternativas.QuickBuy.Infra.Data.Contexto;
using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using LojasAlternativas.QuickBuyBeta.Domain.Interfaces.Repositorio;

namespace LojasAlternativas.QuickBuy.Infra.Data.Repositorios
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(QuickBuyContexto dbContext) : base(dbContext)
        {

        }
    }
}
