using LojasAlternativas.QuickBuy.Infra.Data.Config;
using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace LojasAlternativas.QuickBuy.Infra.Data.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Produto>  Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }


        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new VendaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemVendaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
