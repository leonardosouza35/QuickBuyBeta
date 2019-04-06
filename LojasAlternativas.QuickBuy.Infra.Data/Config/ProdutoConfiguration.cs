using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojasAlternativas.QuickBuy.Infra.Data.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired();

            builder
                .Property(p => p.Descricao)
                .IsRequired();

            builder
                .Property(p => p.Valor)
                .IsRequired();

        }
    }
}
