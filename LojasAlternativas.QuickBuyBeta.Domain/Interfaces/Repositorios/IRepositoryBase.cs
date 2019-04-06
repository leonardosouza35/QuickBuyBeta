using System;
using System.Collections.Generic;

namespace LojasAlternativas.QuickBuyBeta.Domain.Interfaces.Repositorio
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity: class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        void Remover(TEntity entity);
        List<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
    }
}
