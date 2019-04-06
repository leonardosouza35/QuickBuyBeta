using LojasAlternativas.QuickBuyBeta.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojasAlternativas.QuickBuy.Infra.Data.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {

            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.UsuarioId)
                .IsRequired();

            builder
                .Property(v => v.DataVenda)
                .IsRequired();
        }
    }
}
