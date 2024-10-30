using FinancialApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinancialApp.Infrastructure.Persistence
{
    public class FinancialAppDbContext : IdentityDbContext
    {
        public FinancialAppDbContext(DbContextOptions<FinancialAppDbContext> options) : base(options) { }

       
        public DbSet<Domain.Entities.FinancialAppExpenseAndRevenueCategories> FinancialAppExpenseAndRevenueCategories { get; set; }
        public DbSet<Domain.Entities.FinancialAppExpenseAndRevenue> FinancialAppExpenseAndRevenue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FinancialAppExpenseAndRevenue>()
                .HasOne(e => e.CreatedById)
                .WithMany();


            modelBuilder.Entity<FinancialAppExpenseAndRevenue>()
                .HasOne(e => e.CategoriesId)
                .WithMany();
            


        }
    }
}
