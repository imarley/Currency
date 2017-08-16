using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Marley.Currency.Data.EntityConfig.Mapping;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Data.EntityConfig
{
    public class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<decimal>()
                .Configure(p => p.HasPrecision(12, 2));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}