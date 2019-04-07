using System;
using System.Collections.Generic;

namespace LojasAlternativas.QuickBuy.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        void Remover(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
    }
}
