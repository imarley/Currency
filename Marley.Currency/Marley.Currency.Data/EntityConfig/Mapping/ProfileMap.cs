using System.Data.Entity.ModelConfiguration;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Data.EntityConfig.Mapping
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            HasKey(k => k.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}