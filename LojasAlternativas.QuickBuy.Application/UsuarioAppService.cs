using LojasAlternativas.QuickBuy.Application.Interfaces;
using LojasAlternativas.QuickBuy.Infra.Data.Repositorios;
using LojasAlternativas.QuickBuyBeta.Domain.Entity;

namespace LojasAlternativas.QuickBuy.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        public UsuarioAppService(RepositoryBase<Usuario> repositoryBase) : base(repositoryBase)
        {
        }
    }
}
