using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojasAlternativas.QuickBuy.Infra.Data.Config
{
    public class ItemVendaConfiguration : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ProdutoId).IsRequired();
            builder.Property(i => i.Quantidade).IsRequired();
        }
    }
}
