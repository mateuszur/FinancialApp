using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinancialAppExpenseCategoriesTableModification2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "FinancialAppExpenseCategories",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "EncodedNamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FinancialAppExpenseCategories",
                keyColumn: "NamePL",
                keyValue: null,
                column: "NamePL",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "FinancialAppExpenseCategories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "FinancialAppExpenseCategories",
                keyColumn: "EncodedNamePL",
                keyValue: null,
                column: "EncodedNamePL",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "EncodedNamePL",
                table: "FinancialAppExpenseCategories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
