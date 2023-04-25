using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

#nullable disable

namespace Stockify.Migrations
{
    /// <inheritdoc />
    public partial class NewCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Companies",
               columns: table => new
               {
                   Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   CompanyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   Employees = table.Column<int>(type: "int", nullable: false),
                   Market = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Headquarters = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Companies", x => x.Id);

                
               });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "Company");

            //migrationBuilder.RenameTable(
            //    name: "Company",
            //    newName: "Companies");

            //migrationBuilder.AlterColumn<string>(
            //    name: "CompanyName",
            //    table: "Companies",
            //    type: "nvarchar(450)",
            //    nullable: false,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Companies",
            //    table: "Companies",
            //    column: "CompanyName");
        }
    }
}
