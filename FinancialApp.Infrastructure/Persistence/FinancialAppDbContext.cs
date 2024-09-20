using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialApp.Infrastructure.Persistence
{
    public class FinancialAppDbContext : IdentityDbContext
    {
        public FinancialAppDbContext(DbContextOptions<FinancialAppDbContext> options) : base(options) { }

        public DbSet<Domain.Entities.FinancialAppExpenseCategories> FinancialAppExpenseCategories {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
