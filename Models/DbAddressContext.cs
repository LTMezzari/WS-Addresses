using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ws_addresses.Models {
    public class DbAddressContext: DbContext {
        public DbSet<Address> Addresses { get; set; }

        public DbAddressContext(): base("AddressContext") {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}