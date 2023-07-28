using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataAccessLayer.EfClasses
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            base.OnModelCreating(modelBuilder);
    }
}
