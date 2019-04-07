using LojasAlternativas.QuickBuy.Application.Interfaces;
using LojasAlternativas.QuickBuy.Infra.Data.Repositorios;
using System.Collections.Generic;

namespace LojasAlternativas.QuickBuy.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly RepositoryBase<TEntity> _repositoryBase;
        public AppServiceBase(RepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Adicionar(TEntity entity)
        {
            _repositoryBase.Adicionar(entity);
        }

        public void Atualizar(TEntity entity)
        {
            _repositoryBase.Atualizar(entity);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _repositoryBase.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repositoryBase.ObterTodos();
        }

        public void Remover(TEntity entity)
        {
            _repositoryBase.Remover(entity);
        }
    }
}
