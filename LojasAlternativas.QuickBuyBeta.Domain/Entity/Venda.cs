using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojasAlternativas.QuickBuyBeta.Domain.Entity
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public bool Validar()
        {
            if (!Produtos.Any())
                return false;

            return true;
        }

    }
}
