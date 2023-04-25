using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class FK_Crypto_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cryptos_Companies_CompanyName",
                table: "Cryptos");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Cryptos",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Cryptos_CompanyName",
                table: "Cryptos",
                newName: "IX_Cryptos_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cryptos_Companies_CompanyId",
                table: "Cryptos",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cryptos_Companies_CompanyId",
                table: "Cryptos");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Cryptos",
                newName: "CompanyName");

            migrationBuilder.RenameIndex(
                name: "IX_Cryptos_CompanyId",
                table: "Cryptos",
                newName: "IX_Cryptos_CompanyName");

            migrationBuilder.AddForeignKey(
                name: "FK_Cryptos_Companies_CompanyName",
                table: "Cryptos",
                column: "CompanyName",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
