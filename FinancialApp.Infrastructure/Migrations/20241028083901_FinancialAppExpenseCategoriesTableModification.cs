using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinancialAppExpenseCategoriesTableModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EncodedNamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "FinancialAppExpenseCategories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EncodedNamePL",
                table: "FinancialAppExpenseCategories");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "FinancialAppExpenseCategories");

            migrationBuilder.DropColumn(
                name: "NamePL",
                table: "FinancialAppExpenseCategories");
        }
    }
}
