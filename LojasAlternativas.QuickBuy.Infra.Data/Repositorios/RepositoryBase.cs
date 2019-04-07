using LojasAlternativas.QuickBuy.Infra.Data.Contexto;
using LojasAlternativas.QuickBuyBeta.Domain.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojasAlternativas.QuickBuy.Infra.Data.Repositorios
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly QuickBuyContexto _dbContext;

        public RepositoryBase(QuickBuyContexto dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {            
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }
    }
}
