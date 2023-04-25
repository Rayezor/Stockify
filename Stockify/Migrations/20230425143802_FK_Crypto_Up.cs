using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class FK_Crypto_Up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Cryptos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cryptos_CompanyName",
                table: "Cryptos",
                column: "CompanyName");

            migrationBuilder.AddForeignKey(
                name: "FK_Cryptos_Stocks_CompanyName",
                table: "Cryptos",
                column: "CompanyName",
                principalTable: "Stocks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cryptos_Stocks_CompanyName",
                table: "Cryptos");

            migrationBuilder.DropIndex(
                name: "IX_Cryptos_CompanyName",
                table: "Cryptos");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Cryptos");
        }
    }
}
