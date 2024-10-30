using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTableFinancialAppExpenseAndRevenue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialAppExpenseAndRevenue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByIdId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriesIdId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EncodedTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Amount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialAppExpenseAndRevenue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinancialAppExpenseAndRevenue_AspNetUsers_CreatedByIdId",
                        column: x => x.CreatedByIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinancialAppExpenseAndRevenue_FinancialAppExpenseAndRevenueC~",
                        column: x => x.CategoriesIdId,
                        principalTable: "FinancialAppExpenseAndRevenueCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAppExpenseAndRevenue_CategoriesIdId",
                table: "FinancialAppExpenseAndRevenue",
                column: "CategoriesIdId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialAppExpenseAndRevenue_CreatedByIdId",
                table: "FinancialAppExpenseAndRevenue",
                column: "CreatedByIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialAppExpenseAndRevenue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialAppExpenseAndRevenueCategories",
                table: "FinancialAppExpenseAndRevenueCategories");

            migrationBuilder.RenameTable(
                name: "FinancialAppExpenseAndRevenueCategories",
                newName: "FinancialAppExpenseCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialAppExpenseCategories",
                table: "FinancialAppExpenseCategories",
                column: "Id");
        }
    }
}
