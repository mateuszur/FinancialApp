using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameFinancialAppRevenueCategoriesToFinancialAppExpenseAndRevenueCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.RenameTable(
          name: "FinancialAppExpenseCategories",
          newName: "FinancialAppExpenseAndRevenueCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
            name: "FinancialAppExpenseCategories",
            newName: "FinancialAppExpenseAndRevenueCategories");
        }
    }
}
