using System.Data.Entity.ModelConfiguration;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Data.EntityConfig.Mapping
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired();
        }
    }
}