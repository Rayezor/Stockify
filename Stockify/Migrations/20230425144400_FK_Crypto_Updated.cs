using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class FK_Crypto_Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cryptos_Stocks_CompanyName",
                table: "Cryptos");

            migrationBuilder.AddForeignKey(
                name: "FK_Cryptos_Companies_CompanyName",
                table: "Cryptos",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cryptos_Companies_CompanyName",
                table: "Cryptos");

            migrationBuilder.AddForeignKey(
                name: "FK_Cryptos_Stocks_CompanyName",
                table: "Cryptos",
                column: "CompanyName",
                principalTable: "Stocks",
                principalColumn: "Id");
        }
    }
}
