using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataAccessLayer
{
    public class PgSqlContext : DbContext
    {
        public PgSqlContext(DbContextOptions<PgSqlContext> options)
            :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            base.OnModelCreating(modelBuilder);
    }
}
