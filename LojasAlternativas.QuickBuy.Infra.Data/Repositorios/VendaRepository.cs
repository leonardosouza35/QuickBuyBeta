﻿using LojasAlternativas.QuickBuy.Infra.Data.Contexto;
using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using LojasAlternativas.QuickBuyBeta.Domain.Interfaces.Repositorio;

namespace LojasAlternativas.QuickBuy.Infra.Data.Repositorios
{
    public class VendaRepository : RepositoryBase<Venda>, IVendaRepository
    {
        public VendaRepository(QuickBuyContexto dbContext) : base(dbContext)
        {
        }
    }
}
