using System;
using System.Collections.Generic;
using System.Text;

namespace LojasAlternativas.QuickBuyBeta.Domain.Entity
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }

    }
}
