using System;
using System.Collections.Generic;
using System.Text;

namespace LojasAlternativas.QuickBuyBeta.Domain.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Email))
                return false;

            return true;
        }

    }
}
