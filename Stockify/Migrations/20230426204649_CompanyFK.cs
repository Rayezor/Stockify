using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class CompanyFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StockId",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StockId",
                table: "Companies",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Stocks_StockId",
                table: "Companies",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Stocks_StockId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_StockId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Companies");
        }
    }
}
