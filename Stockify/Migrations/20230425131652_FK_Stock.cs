using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class FK_Stock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "Stocks",
                type: "nvarchar(450)",
                nullable: true);

           

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CompanyId",
                table: "Stocks",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Companies_CompanyId",
                table: "Stocks",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Companies_CompanyId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_CompanyId",
                table: "Stocks");

           

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Stocks");

           

           
        }
    }
}
