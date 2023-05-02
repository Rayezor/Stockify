using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class AddCryptoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CryptoId",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CryptoId",
                table: "Companies",
                column: "CryptoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Cryptos_CryptoId",
                table: "Companies",
                column: "CryptoId",
                principalTable: "Cryptos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Cryptos_CryptoId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CryptoId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CryptoId",
                table: "Companies");
        }
    }
}
